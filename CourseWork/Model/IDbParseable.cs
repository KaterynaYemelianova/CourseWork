using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public interface IDbParseable
    {
        string TableName { get; }
        int ID { get; }
        string IdFieldName { get; }
        void FillWith(DataRow DR);
        Dictionary<string, string> GetDbParams();
    }
}
