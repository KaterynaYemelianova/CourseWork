using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CourseWork.Model
{
    public class DbContext {

        private const string ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Катя\Documents\db.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection SqlCon = new SqlConnection(ConnectionString);

        public static DataTable GetDataTable<T>() where T : IDbParseable, new()
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + new T().TableName, SqlCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            SqlCon.Close();

            return dt;
        }

        public static List<T> Select<T>() where T : IDbParseable, new()
        {
            DataTable dt = GetDataTable<T>();

            List<T> result = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T item = new T();
                item.FillWith(dr);
                result.Add(item);
            }
            
            return result;
        }

        public static List<T> Select<T>(params Predicate<T>[] PS) where T : IDbParseable, new()
        {
            List<T> Targets = DbContext.Select<T>().ToList();

            foreach (Predicate<T> P in PS)
                Targets = Targets.Where(item => P(item)).ToList();

            return Targets;
        }

        public static T Single<T>(params Predicate<T>[] PS) where T : IDbParseable, new()
        {
            return DbContext.Select<T>(PS).FirstOrDefault();
        }

        public static bool Insert<T>(T Item) where T : IDbParseable, new()
        {
            SqlCon.Open();
            Dictionary<string, string> Params = Item.GetDbParams();
            string Fields = String.Join(", ", Params.Select(KVP => KVP.Key));
            string ValParams = String.Join(", ", Params.Select(KVP => "@" + KVP.Key));
            SqlCommand cmd = new SqlCommand("INSERT INTO " + new T().TableName + "(" + Fields + ") VALUES(" + ValParams + ");", SqlCon);

            foreach (KeyValuePair<string, string> data in Params)
            {
                cmd.Parameters.Add("@" + data.Key, data.Value);
            }
            int result = cmd.ExecuteNonQuery();
            SqlCon.Close();
            return result == 1;
        }

        public static bool Delete<T>(T Item) where T : IDbParseable
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + Item.TableName + " WHERE " + Item.IdFieldName + " = @id", SqlCon);
            cmd.Parameters.Add("@id", Item.ID);
            int result = cmd.ExecuteNonQuery();
            SqlCon.Close();
            return result == 1;
        }
    }
}
