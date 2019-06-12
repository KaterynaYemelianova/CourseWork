using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Star_Substance : ModelItem
    {
        public int ID { get; private set; }
        public int StarId { get; private set; }
        public int SubstanceId { get; private set; }
        public double Percentage { get; private set; }

        public override string DataTableName { get { return "Star_Substance"; } }
        public override string ViewTableName { get { return "Содержание веществ в составе звезды"; } }
        public override string IdFieldName { get { return "id"; } }

        public Star_Substance() : base() { }
        public Star_Substance(int StarId, int SubstanceId, double Percentage, int ID = Constants.DefaultIndex)
        {
            this.ID = ID;
            this.StarId = StarId;
            this.SubstanceId = SubstanceId;
            this.Percentage = Percentage;
        }

        protected override void ConfigureDataFields()
        {
            AddFieldConfig(item => ID = Convert.ToInt32(item[0]), "id");
            AddFieldConfig(item => StarId = Convert.ToInt32(item[0]), "star_id");
            AddFieldConfig(item => SubstanceId = Convert.ToInt32(item[0]), "substance_id");
            AddFieldConfig(item => Percentage = Convert.ToDouble(item[0].ToString().Replace(".", ",")), "percentage");
        }

        protected override void ConfigureViewFields()
        {
            //
        }

        protected override void ConfigureFieldGetters()
        {
            FieldsGetters.Add("id", () => ID == Constants.DefaultIndex ? null : ID.ToString());
            FieldsGetters.Add("star_id", () => StarId.ToString());
            FieldsGetters.Add("substance_id", () => SubstanceId.ToString());
            FieldsGetters.Add("percentage", () => Percentage.ToString().Replace(",", "."));
        }
    }
}
