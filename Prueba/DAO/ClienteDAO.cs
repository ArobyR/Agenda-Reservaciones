using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AgendaCita.Models;
using AgendaCita; // to create the validation in the future?

namespace AgendaCita.DAO
{
    class ClienteDAO
    {
        // the querys

        MySqlConnection cn = null; // para la conexion con la base de datos
        MySqlCommand cmd = null; // para ejecutar la consulta
        MySqlDataReader reader = null; // para leer los datos de retorno de las consultas

        // es cualquier SQL que no devuelve valores, pero en realidad 
        // esta realizando alguna forma de trabajo como insertar, eleminar y etc..
        private bool ExecuteNonQuery(string query)
        {
            try
            {
                cn = ConexionDB.GetMySqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }

            return false;
        }

        // sera el tipo de consulta que devolvera un unico valor...
        private long ExecuteScalar(string query)
        {
            try
            {
                cn = ConexionDB.GetMySqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;

                return Convert.ToInt64(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
                return 0;
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
        }

        public bool InsercionUsuario (ClienteModel model)
        {
            //Guid IdUsuarioGuid = new Guid(); guid = Guid.NewGuid("N").Substring(0, 15);
            string IdUsuarioGuid = Guid.NewGuid().ToString();
            model.IdUsuario = IdUsuarioGuid.ToString();
            string query = $@"INSERT INTO usuario (id_usuario, nombre_usuario, apellido_usuario, tipo_doc, documento)
                             VALUES ('{model.IdUsuario}', '{model.NombreUsuario}', '{model.ApellidoUsuario}', '{model.TipoDoc}', '{model.Documento}')";

            long id = ExecuteScalar(query);

            foreach (TelefonoClienteModel item in model.Telefonos) 
            {
                query = $"INSERT telefono_usuario(id_usuario, telefono, tipo)" +
                    $"VALUES('{id}', '{item.Telefono}', '{item.Tipo}')";
                ExecuteNonQuery(query);
            }

            return true;
        }

        public bool Update(ClienteModel model)
        {
            string query = "";

            return ExecuteNonQuery(query);
        }

        public bool DeleteUser (int id)
        {
            // good think
            string query = $"DELETE FROM usuario WHERE id_usuario = {id}";
            return ExecuteNonQuery(query);
        }

        public List<ClienteModel> GetUser()
        {
            string  query = $"SELECT * FROM usuario";
            return ExecuteQuery(query);
        }

        private List<ClienteModel> ExecuteQuery(string query)
        {
            var ClienteList = new List<ClienteModel>();
            try
            {
                cn = ConexionDB.GetMySqlConnection();
                cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = cn;

                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    ClienteModel cliente = new ClienteModel();
                    cliente.IdUsuario = reader["id_usuario"].ToString();
                    cliente.NombreUsuario = reader["nombre_usuario"].ToString();
                    cliente.ApellidoUsuario = reader["apellido_usuario"].ToString();
                    cliente.TipoDoc = reader["tipo_doc"].ToString();
                    cliente.Documento = reader["documento"].ToString();

                    ClienteList.Add(cliente);
                }

                return ClienteList;
            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);

            }

            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
            }

            return null;
        } 
    }
}
