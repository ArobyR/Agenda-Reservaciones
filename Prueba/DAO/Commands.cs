using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AgendaCita.DAO
{
    static class Commands
    {
        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                using (var cn = ConexionDB.GetMySqlConnection())
                {
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = cn;

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            cn.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;

            }
            return false;
        }


        public static List<T> Query<T>(string query) where T : new()
        {
            List<T> Lista = new List<T>();
            var cn = ConexionDB.GetMySqlConnection();
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cn;

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                T t = new T();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Type type = t.GetType();
                    PropertyInfo prop = type.GetProperty(ToPascalCase(reader.GetName(i)));
                    prop.SetValue(t, reader.GetValue(i), null);

                }
                Lista.Add(t);
            }
            reader.Close();

            return Lista;
        }

        private static string ToPascalCase(string text)
        {
            text = Regex.Replace(text, "_[a-z]", delegate (Match m)
            {
                return m.ToString().TrimStart('_').ToUpper();
            });

            var temp = text.ToCharArray();
            temp[0] = temp[0].ToString().ToUpperInvariant().ToCharArray()[0];
            return new String(temp);
        }
    }
}
