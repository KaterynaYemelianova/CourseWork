using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public class Substance : ModelItem //IDbParseable
    {
        public int ID { get; private set; }
        public string Formula { get; private set; }
        public string Name { get; private set; }

        public override string DataTableName { get { return "Substance"; } }
        public override string ViewTableName { get { return "Вещество"; } }
        public override string IdFieldName { get { return "id"; } }

        public Substance() : base() { }
        public Substance(string name, string formula, int id = Constants.DefaultIndex) : base()
        {
            this.ID = id;
            this.Name = name;
            this.Formula = formula;        

            PostDataLoadingHandle();
            ConfigureViewFields();
        }

        protected override void ConfigureDataFields()
        {
            AddFieldConfig(item => ID = Convert.ToInt32(item[0]), "id");
            AddFieldConfig(item => Name = item[0].ToString(), "name");
            AddFieldConfig(item => Formula = item[0].ToString(), "formula");
        }

        protected override void ConfigureFieldGetters()
        {
            FieldsGetters.Add("id", () => ID == Constants.DefaultIndex ? null : ID.ToString());
            FieldsGetters.Add("name", () => Name);
            FieldsGetters.Add("formula", () => Formula.ToString());
        }

        protected override void ConfigureViewFields()
        {
            ViewConfig.Add("Название", () => Name);
            ViewConfig.Add("Формула", () => Formula);
        }

        public override string ToString()
        {
            return Name + " - " + Formula;
        }
    }
}
