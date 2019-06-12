using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CourseWork.Database;

namespace CourseWork.Model
{
    public abstract class ModelItem : IDbItem, IViewItem
    {
        public abstract string DataTableName { get; }
        public abstract string ViewTableName { get; }
        public abstract string IdFieldName { get; }

        public List<int> ColumnMaxSymbolCount { get; private set; }
        public virtual int RowCount { get { return 1; } }

        /// <summary>
        /// Should fill FieldsConfig and transients
        /// </summary>
        protected abstract void ConfigureDataFields();

        /// <summary>
        /// Should fill ViewConfig
        /// </summary>
        protected abstract void ConfigureViewFields();

        protected abstract void ConfigureFieldGetters();

        public virtual void PostDataLoadingHandle() { }

        protected delegate string FieldGetter();
        protected delegate void FieldSetter(List<Object> value);
        protected delegate Object ViewSelector();

        private Dictionary<string[], FieldSetter> FieldsConfig = new Dictionary<string[], FieldSetter>();
        protected Dictionary<string, FieldGetter> FieldsGetters = new Dictionary<string, FieldGetter>();
        protected Dictionary<string, ViewSelector> ViewConfig = new Dictionary<string, ViewSelector>();

        protected void AddFieldConfig(FieldSetter Setter, params string[] FieldNames)
        {
            FieldsConfig.Add(FieldNames, Setter);
        }

        public ModelItem()
        {
            ColumnMaxSymbolCount = new List<int>();
            ConfigureDataFields();
            ConfigureFieldGetters();
        }

        public void CopyFrom(ModelItem item)
        {
            foreach (KeyValuePair<string[], FieldSetter> setter in FieldsConfig)
            {
                if (setter.Key.Contains(IdFieldName))
                    continue;

                List<object> data = new List<object>();
                foreach (string field in setter.Key)
                    data.Add(item.FieldsGetters[field]());

                setter.Value(data);
            }
        }

        public Dictionary<string, string> GetData()
        {
            Dictionary<string, string> Data = new Dictionary<string, string>();

            foreach (KeyValuePair<string, FieldGetter> field in FieldsGetters)
            {
                string value = field.Value();
                if (value != null)
                    Data.Add(field.Key, value);
            }

            return Data;
        }

        public string GetId()
        {
            return FieldsGetters[IdFieldName]().ToString();
        }

        public void LoadFrom(SqlDataReader reader)
        {
            foreach (KeyValuePair<string[], FieldSetter> field in FieldsConfig)
            {
                List<Object> inputs = new List<object>();
                foreach (string key in field.Key)
                    inputs.Add(reader[key]);
                field.Value(inputs);
            }

            PostDataLoadingHandle();
            ConfigureViewFields();
        }

        public void AddTo(DataTable table)
        {
            DataRow row = table.NewRow();

            foreach (KeyValuePair<string, ViewSelector> viewField in ViewConfig)
            {
                string value = viewField.Value().ToString();
                ColumnMaxSymbolCount.Add(value.Split('\n').Max(str => str.Length));
                row[viewField.Key] = value;
            }

            table.Rows.Add(row);
        }

        public DataTable GetViewConfiguration()
        {
            DataTable table = new DataTable(ViewTableName);

            foreach (KeyValuePair<string, ViewSelector> viewField in ViewConfig)
                table.Columns.Add(viewField.Key);

            return table;
        }
    }
}
