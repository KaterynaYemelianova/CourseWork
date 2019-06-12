using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public class Discoverer : ModelItem //IDbParseable
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public override string DataTableName { get { return "Discoverer"; } }
        public override string ViewTableName { get { return "Первооткрыватель"; } }
        public override string IdFieldName { get { return "id"; } }

        public Discoverer() : base() { }
        public Discoverer(string name, int id = Constants.DefaultIndex) : base()
        {
            this.ID = id;
            this.Name = name;

            PostDataLoadingHandle();
            ConfigureViewFields();
        }

        protected override void ConfigureDataFields()
        {
            AddFieldConfig(item => ID = Convert.ToInt32(item[0]), "id");
            AddFieldConfig(item => Name = item[0].ToString(), "name");
        }

        protected override void ConfigureFieldGetters()
        {
            FieldsGetters.Add("id", () => ID == Constants.DefaultIndex ? null : ID.ToString());
            FieldsGetters.Add("name", () => Name);
        }

        protected override void ConfigureViewFields()
        {
            ViewConfig.Add("Название", () => Name);
        }

        public override string ToString()
        {
            return Name;
        }

        /*public void FillWith(DataRow DR)
        {
            this.ID = Convert.ToInt32(DR["id"]);
            this.Name = (DR["name"]).ToString();
        }

        public void FillRow(DataRow DR)
        {
            DR["id"] = this.ID.ToString();
            DR["name"] = this.Name;
        }

        public Dictionary<string, string> GetDbParams()
        {
            Dictionary<string, string> D = new Dictionary<string, string>();

            if (ID != AutoID)
                D.Add("id", ID.ToString());

            D.Add("name", Name);

            return D;
        }*/
    }
}
