using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Database;

namespace CourseWork.Model
{
    public class Star : ModelItem //IDbParseable
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Date { get; private set; }
        public Discoverer SDiscoverer { get; private set; }
        public Asterism StarAsterism { get; private set; }
        public double Distance { get; private set; }
        public double Mass { get; private set; }
        public double TMin { get; private set; }
        public double TMax { get; private set; }
        public Color VisColor { get; private set; }

        public Dictionary<Substance, double> SubstancesPercentage { get; private set; }

        public override string DataTableName { get { return "StarTable"; } }
        public override string ViewTableName { get { return "Звезда"; } }
        public override string IdFieldName { get { return "id"; } }
        public override int RowCount { get { return SubstancesPercentage.Count; } }

        public Star() : base() { }
        public Star(string name, int date, Discoverer discoverer, Asterism starasterism, 
                    double distance, double mass, double tmin, double tmax, 
                    Color viscolor, Dictionary<Substance, double> SubstancesPercentage = null, 
                    int id = Constants.DefaultIndex) : base()
        {
            this.ID = id;
            this.Name = name;
            this.Date = date;
            this.SDiscoverer = discoverer;
            this.StarAsterism = starasterism;
            this.Distance = distance;
            this.Mass = mass;
            this.TMin = tmin;
            this.TMax = tmax;
            this.VisColor = viscolor;

            this.SubstancesPercentage = SubstancesPercentage == null ? new Dictionary<Substance, double>() : SubstancesPercentage;

            PostDataLoadingHandle();
            ConfigureViewFields();
        }

        protected override void ConfigureDataFields() // Агрегирует значения полей таблицы в состояние объекта
        {
            AddFieldConfig(item => ID = Convert.ToInt32(item[0]), "id");
            AddFieldConfig(item => Name = item[0].ToString(), "name");
            AddFieldConfig(item => Date = Convert.ToInt32(item[0]), "date");
            AddFieldConfig(item => SDiscoverer = item[0] == null || DBNull.Value.Equals(item[0])? null : Archive.Discoverers.SingleOrDefault(D => D.ID == Convert.ToInt32(item[0])), "discoverer_id");
            AddFieldConfig(item => StarAsterism = item[0] == null || DBNull.Value.Equals(item[0]) ? null : Archive.Asterisms.SingleOrDefault(A => A.ID == Convert.ToInt32(item[0])), "asterism_id");
            AddFieldConfig(item => Distance = Convert.ToDouble(item[0].ToString().Replace('.', ',')), "distance");
            AddFieldConfig(item => Mass = Convert.ToDouble(item[0].ToString().Replace('.', ',')), "mass");
            AddFieldConfig(item => TMin = Convert.ToDouble(item[0].ToString().Replace('.', ',')), "t_min");
            AddFieldConfig(item => TMax = Convert.ToDouble(item[0].ToString().Replace('.', ',')), "t_max");
            AddFieldConfig(item => VisColor = Color.FromArgb(Convert.ToInt32(item[0]), Convert.ToInt32(item[1]), Convert.ToInt32(item[2])), "r", "g", "b");
        }

        public override void PostDataLoadingHandle()
        {
            this.SubstancesPercentage = Archive.StarSubstances.Where(SSP => SSP.StarId == ID).
                                        ToDictionary(SSP => Archive.Substances.Single(S => S.ID == SSP.SubstanceId),
                                                     SSP => SSP.Percentage);
        }

        protected override void ConfigureFieldGetters() // Разворачивает состояние объекта в поля таблицы
        {
            FieldsGetters.Add("id", () => ID == Constants.DefaultIndex ? null : ID.ToString());
            FieldsGetters.Add("name", () => Name);
            FieldsGetters.Add("date", () => Date.ToString());
            FieldsGetters.Add("discoverer_id", () => SDiscoverer == null ? null : SDiscoverer.ID.ToString());
            FieldsGetters.Add("asterism_id", () => StarAsterism == null ? null : StarAsterism.ID.ToString());
            FieldsGetters.Add("distance", () => Distance.ToString().Replace(',', '.'));
            FieldsGetters.Add("mass", () => Mass.ToString().Replace(',', '.'));
            FieldsGetters.Add("t_min", () => TMin.ToString().Replace(',', '.'));
            FieldsGetters.Add("t_max", () => TMax.ToString().Replace(',', '.'));
            FieldsGetters.Add("r", () => VisColor.R.ToString());
            FieldsGetters.Add("g", () => VisColor.G.ToString());
            FieldsGetters.Add("b", () => VisColor.B.ToString());
        }

        protected override void ConfigureViewFields() // Выбор и агрегация полей объекта, которые будут отображаться на форме
        {
            ViewConfig.Add("Название", () => Name);
            ViewConfig.Add("Дата открытия", () => Date);
            ViewConfig.Add("Первооткрывыатель", () => SDiscoverer == null ? "-" : SDiscoverer.Name);
            ViewConfig.Add("Созвездие", () => StarAsterism == null ? "-" : StarAsterism.Name);
            ViewConfig.Add("Расстояние", () => Distance);
            ViewConfig.Add("Масса", () => Mass);
            ViewConfig.Add("Минимальная температура", () => TMin);
            ViewConfig.Add("Максимальная температура", () => TMax);
            //ViewConfig.Add("Цвет", () => VisColor);
            ViewConfig.Add("Содержание веществ", () => String.Join("\n", SubstancesPercentage.Select(S => S.Key.ToString() + ": " + S.Value.ToString())));
        }
    }
}
