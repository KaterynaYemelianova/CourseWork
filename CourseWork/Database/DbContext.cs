using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CourseWork.Model;

namespace CourseWork.Database
{
    public class DbContext 
    {
        public class ExistingUniqueCodeException : Exception { }
        public class RecordNotExistsException : Exception { }
        public class TransientCurruptionException : Exception { }

        private const string ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Катя\Documents\db.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection SqlCon = new SqlConnection(ConnectionString);

        public static List<T> Select<T>() where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>(), null);
        }

        public static List<T> SelectWhere<T>(string key, string value) where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>() + " WHERE @key = @value",
                                    new SqlParameter("@key", key),
                                    new SqlParameter("@value", value));
        }

        public static T Single<T>(string id) where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>() +
                                    " WHERE " + Constants.GetIdFieldName<T>() + " = @value",
                                    new SqlParameter("@value", id)).FirstOrDefault();
        }

        private static List<T> ExecuteSelect<T>(string commandText, params SqlParameter[] parameters) where T : IDbItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(commandText, connection);

                if (parameters != null)
                    foreach (SqlParameter parameter in parameters)
                        cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<T> result = new List<T>();
                while (reader.Read())
                {
                    T record = new T();
                    record.LoadFrom(reader);
                    result.Add(record);
                }
                return result;
            }
        }

        public static string Insert<T>(T item) where T : ModelItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Dictionary<string, string> Data = item.GetData();
                List<SqlParameter> Values = Data.Values.Select((V, i) => new SqlParameter("@value" + i, V)).ToList();

                string Keys = String.Join(", ", Data.Keys.ToList());
                string ValueString = String.Join(", ", Values);

                string CommandText = "INSERT INTO " + Constants.GetTableName<T>() + "(" + Keys + ") OUTPUT inserted." + item.IdFieldName + " VALUES(" + ValueString + ");";
                SqlCommand cmd = new SqlCommand(CommandText, connection);

                foreach (SqlParameter value in Values)
                    cmd.Parameters.Add(value);

                connection.Open();
                string last_id = "";

                try { last_id = cmd.ExecuteScalar().ToString(); }
                catch { throw new ExistingUniqueCodeException(); }

                return last_id;
            }
        }

        public static bool Update<T>(T item) where T : ModelItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Dictionary<string, string> Data = item.GetData();
                List<KeyValuePair<string, SqlParameter>> Pairs = Data.Where(d => d.Key != item.IdFieldName).
                                                          Select((V, i) => new KeyValuePair<string, SqlParameter>(
                                                              V.Key, new SqlParameter("@value" + i, V.Value))
                                                          ).ToList();

                string Updates = String.Join(", ", Pairs.Select(V => V.Key + " = " + V.Value.ParameterName));

                string CommandText = "UPDATE " + Constants.GetTableName<T>() + " SET " + Updates + " WHERE " + item.IdFieldName + " = @id";
                SqlCommand cmd = new SqlCommand(CommandText, connection);

                foreach (KeyValuePair<string, SqlParameter> pair in Pairs)
                    cmd.Parameters.Add(pair.Value);

                cmd.Parameters.Add("@id", item.GetId());

                connection.Open();
                int affected = 0;

                try { affected = cmd.ExecuteNonQuery(); }
                catch { throw new RecordNotExistsException(); }

                return affected == 1;
            }
        }

        public static bool Delete<T>(T item) where T : ModelItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string CommandText = "DELETE FROM " + item.DataTableName + " WHERE " + item.IdFieldName + " = @id";
                SqlCommand cmd = new SqlCommand(CommandText, connection);

                cmd.Parameters.Add("@id", item.GetId());

                connection.Open();
                int affected = 0;

                try { affected = cmd.ExecuteNonQuery(); }
                catch { throw new TransientCurruptionException(); }

                return affected == 1;
            }
        }

        /*public static DataTable GetDataTable<T>() where T : IDbParseable, new()
        {
            SqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + new T().TableName, SqlCon);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            SqlCon.Close();

            return dt;
        }

        public static List<T> Select<T>() where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>(), null);
        }

        public static List<T> SelectWhere<T>(string key, string value) where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>() + " WHERE @key = @value",
                                    new SqlParameter("@key", key),
                                    new SqlParameter("@value", value));
        }

        public static T Single<T>(string id) where T : IDbItem, new()
        {
            return ExecuteSelect<T>("SELECT * FROM " + Constants.GetTableName<T>() +
                                    " WHERE " + Constants.GetIdFieldName<T>() + " = @value",
                                    new SqlParameter("@value", id)).FirstOrDefault();
        }

        private static List<T> ExecuteSelect<T>(string commandText, params SqlParameter[] parameters) where T : IDbItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(commandText, connection);

                if (parameters != null)
                    foreach (SqlParameter parameter in parameters)
                        cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<T> result = new List<T>();
                while (reader.Read())
                {
                    T record = new T();
                    record.LoadFrom(reader);
                    result.Add(record);
                }
                return result;
            }
        }

        public static string Insert<T>(T item) where T : ModelItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Dictionary<string, string> Data = item.GetData();
                List<SqlParameter> Values = Data.Values.Select((V, i) => new SqlParameter("@value" + i, V)).ToList();

                string Keys = String.Join(", ", Data.Keys.ToList());
                string ValueString = String.Join(", ", Values);

                string CommandText = "INSERT INTO " + Constants.GetTableName<T>() + "(" + Keys + ") OUTPUT inserted." + item.IdFieldName + " VALUES(" + ValueString + ");";
                SqlCommand cmd = new SqlCommand(CommandText, connection);

                foreach (SqlParameter value in Values)
                    cmd.Parameters.Add(value);

                connection.Open();
                string last_id = "";

                try { last_id = cmd.ExecuteScalar().ToString(); }
                catch { throw new ExistingUniqueCodeException(); }

                return last_id;
            }
        }

        public static bool Update<T>(T item) where T : ModelItem, new()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Dictionary<string, string> Data = item.GetData();
                List<KeyValuePair<string, SqlParameter>> Pairs = Data.Where(d => d.Key != item.IdFieldName).
                                                          Select((V, i) => new KeyValuePair<string, SqlParameter>(
                                                              V.Key, new SqlParameter("@value" + i, V.Value))
                                                          ).ToList();

                string Updates = String.Join(", ", Pairs.Select(V => V.Key + " = " + V.Value.ParameterName));

                string CommandText = "UPDATE " + Constants.GetTableName<T>() + " SET " + Updates + " WHERE " + item.IdFieldName + " = @id";
                SqlCommand cmd = new SqlCommand(CommandText, connection);

                foreach (KeyValuePair<string, SqlParameter> pair in Pairs)
                    cmd.Parameters.Add(pair.Value);

                cmd.Parameters.Add("@id", item.GetId());

                connection.Open();
                int affected = 0;

                try { affected = cmd.ExecuteNonQuery(); }
                catch { throw new RecordNotExistsException(); }

                return affected == 1;
            }
        }


        /*public static List<T> Select<T>() where T : IDbParseable, new()
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
        }*/
    }
}
