using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Model;
using CourseWork.Database;

namespace CourseWork.Database
{
    public interface IDbItem
    {
        string DataTableName { get; }
        string IdFieldName { get; }
        void LoadFrom(SqlDataReader reader);
    }
}
