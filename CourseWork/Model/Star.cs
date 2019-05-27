using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Star : IDbParseable
    {
        public const int AutoID = -1;

        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Date { get; private set; }
        public string Developer { get; private set; }
        public Asterism StarAsterism { get; private set; }
        public double Distance { get; private set; }
        public double Mass { get; private set; }
        public double TMin { get; private set; }
        public double TMax { get; private set; }
        public Color VisColor { get; private set; }

        public Star(string name, int date, string developer, Asterism starasterism,
                    double distance, double mass, double tmin, double tmax, 
                    Color viscolor, int id = AutoID)
        {
            this.ID = id;
            this.Name = name;
            this.Date = date;
            this.Developer = developer;
            this.StarAsterism = starasterism;
            this.Distance = distance;
            this.Mass = mass;
            this.TMin = tmin;
            this.TMax = tmax;
            this.VisColor = viscolor;
        }

        public Star()
        {
            this.ID = AutoID;
        }

        public string TableName
        {
            get { return "StarTable "; }
        }

        public string IdFieldName
        {
            get { return "id"; }
        }

        public void FillWith(System.Data.DataRow DR)
        {
            this.ID = Convert.ToInt32(DR["id"]);
            this.Name = (DR["name"]).ToString();
            this.Date = Convert.ToInt32(DR["date"]);
            this.Developer = DR["developer"].ToString();

            this.StarAsterism = DbContext.Single<Asterism>(A => A.ID == Convert.ToInt32(DR["asterism_id"]));

            this.Distance = Convert.ToSingle(DR["developer"]);
            this.TMin = Convert.ToSingle(DR["t_min"]);
            this.TMax = Convert.ToSingle(DR["t_max"]);
            this.VisColor = Color.FromArgb(Convert.ToInt32(DR["r"]), Convert.ToInt32(DR["g"]), Convert.ToInt32(DR["b"]));
        }

        public Dictionary<string, string> GetDbParams()
        {
            Dictionary<string, string> D = new Dictionary<string, string>();

            if (ID != AutoID)
                D.Add("id", ID.ToString());

            D.Add("name", Name);
            D.Add("date", Date.ToString());
            D.Add("developer", Developer);
            D.Add("asterism_id", StarAsterism.ID.ToString());
            D.Add("distance", Distance.ToString());
            D.Add("mass", Mass.ToString());
            D.Add("t_min", TMin.ToString());
            D.Add("t_max", TMax.ToString());
            D.Add("r", VisColor.R.ToString());
            D.Add("g", VisColor.G.ToString());
            D.Add("b", VisColor.B.ToString());

            return D;
        }
    }
}
