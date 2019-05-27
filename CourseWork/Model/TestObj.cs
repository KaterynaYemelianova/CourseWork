using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public class TestObj : IDbParseable
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public string IdFieldName { get { return "id"; } }

        public TestObj(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public TestObj(string name)
        {
            this.ID = -1;
            this.Name = name;
        }

        public TestObj() { }

        public string TableName
        {
            get { return "TestTable"; }
        }

        public void FillWith(DataRow DR)
        {
            this.ID = Convert.ToInt32(DR["id"]);
            this.Name = DR["name"].ToString();
        }

        Dictionary<string, string> IDbParseable.GetDbParams()
        {
            Dictionary<string, string> Data = new Dictionary<string, string>();
            if (ID != -1)
                Data.Add("id", this.ID.ToString());
            Data.Add("name", this.Name.ToString());
            return Data;
        }
    }
}
