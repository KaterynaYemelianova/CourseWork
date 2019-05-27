using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public class Asterism : IDbParseable
    {
        public const int AutoID = -1;

        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Square { get; private set; }

        public Asterism(string name, double square, int id = AutoID)
        {
            this.ID = id;
            this.Name = name;
            this.Square = square;
        }

        public Asterism()
        {
            this.ID = AutoID;
        }

        public string TableName
        {
            get { return "AsterismTable "; }
        }

        public string IdFieldName
        {
            get { return "id"; }
        }

        public void FillWith(DataRow DR)
        {
            this.ID = Convert.ToInt32(DR["id"]);
            this.Name = (DR["name"]).ToString();
            this.Square = Convert.ToSingle(DR["square"]);
        }

        public void FillRow(DataRow DR)
        {
            DR["id"] = this.ID.ToString();
            DR["name"] = this.Name;
            DR["square"] = this.Square;
        }

        public Dictionary<string, string> GetDbParams()
        {
            Dictionary<string, string> D = new Dictionary<string, string>();

            if (ID != AutoID)
                D.Add("id", ID.ToString());

            D.Add("name", Name);
            D.Add("square", Square.ToString());

            return D;
        }
    }
}
