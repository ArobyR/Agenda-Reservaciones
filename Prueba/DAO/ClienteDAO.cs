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
        MySqlConnection cn = null; // para la conexion con la base de datos
        MySqlCommand cmd = null; // para ejecutar la consulta
        MySqlDataReader reader = null; // para leer los datos de retorno de las consultas

        // es cualquier SQL que no devuelve valores, pero en realidad 
        // esta realizando alguna forma de trabajo como insertar, eleminar y etc..
        private bool ExecuteNonQuery(string query)
        {
            try
            {
                var cn = ConexionDB.GetMySqlConnection();
                var cmd = new MySqlCommand();
                cmd.CommandText = query;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cn.Close();
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

        public bool InsertUsuario (ClienteModel model)
        {
            //Guid IdUsuarioGuid = new Guid(); guid = Guid.NewGuid("N").Substring(0, 15);
            string IdUsuarioGuid = Guid.NewGuid().ToString();
            model.IdUsuario = IdUsuarioGuid.ToString();
            string query = $@"INSERT INTO usuario (id_usuario, nombre_usuario, apellido_usuario, tipo_doc, documento)
                             VALUES ('{model.IdUsuario}', '{model.NombreUsuario}', '{model.ApellidoUsuario}', '{model.TipoDoc}', '{model.Documento}')";
            
            //ExecuteNonQuery(query);

            foreach (TelefonoClienteModel item in model.Telefonos) 
            {
                query = $"INSERT telefono_usuario(id_usuario, telefono, tipo)" +
                    $"VALUES('{model.IdUsuario}', '{item.Telefono}', '{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }
            
            return true;
        }

        public List<ClienteModel> ReadUsuario(ClienteModel model)
        {
            string query = $@"SELECT id_usuario, nombre_usuario, apellido_usuario, tipo_doc, documento WHERE documento = '{model.Documento}' LIMIT 1";

            //return ExecuteQuery(query);
            return Commands.Query<ClienteModel>(query);
        }

        public bool Update(ClienteModel model)
        {
            string query = "";

            return ExecuteNonQuery(query);
        }

        public bool DeleteUser (string id)
        {
            // good think
            string query = $"DELETE FROM usuario WHERE id_usuario = {id}";
            return Commands.ExecuteNonQuery(query);
        }

        public List<ClienteModel> GetClientes()
        {
            string  query = $"SELECT * FROM usuario";
            var ClienteList = Commands.Query<ClienteModel>(query);

            foreach(var item in ClienteList)
            {
                item.Telefonos = GetTelefonoClientes(item.IdUsuario);
            }

            return ClienteList;
        }

        public List<TelefonoClienteModel> GetTelefonoClientes(string id)
        {
            string query = $"SELECT id_usuario, telefono, tipo FROM telefono_usuario WHERE id_usuario = {id};";
            return Commands.Query<TelefonoClienteModel>(query);
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
                
                // mi modificacion de este metodo, basicamente, si hay tablas que me devuelva x, sino mensaje o return null :)
                if (reader.HasRows)
                {
                    while (reader.Read())
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
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se encontraron registros.");
                }

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
