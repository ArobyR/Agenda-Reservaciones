using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AgendaCita.Models;
using AgendaCita; 

namespace AgendaCita.DAO
{
    class ClienteDAO
    {
        MySqlConnection cn = null; // para la conexion con la base de datos
        MySqlCommand cmd = null; // para ejecutar la consulta
        MySqlDataReader reader = null; // para leer los datos de retorno de las consultas

        public bool InsertUsuario (ClienteModel model)
        {
            //Guid IdUsuarioGuid = new Guid(); guid = Guid.NewGuid("N").Substring(0, 15);
            string IdUsuarioGuid = Guid.NewGuid().ToString("N");
            model.IdUsuario = IdUsuarioGuid.ToString();
            string query = $@"INSERT INTO usuario (id_usuario, nombre_usuario, apellido_usuario, tipo_documento, documento)
                             VALUES ('{model.IdUsuario}', '{model.NombreUsuario}', '{model.ApellidoUsuario}', '{model.TipoDocumento}', '{model.Documento}')";

            Commands.ExecuteNonQuery(query);
            foreach (TelefonoClienteModel item in model.Telefonos) 
            {
                query = $"INSERT INTO telefono_usuario (id_usuario, telefono, tipo)" +
                    $"VALUES ('{model.IdUsuario}', '{item.Telefono}', '{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }
            return true;
        }

        public List<ClienteModel> ReadUsuario(string document)
        {
            string query = $"SELECT id_usuario, nombre_usuario, apellido_usuario, tipo_documento, documento FROM usuario WHERE documento = '{document}' LIMIT 1";

            return Commands.Query<ClienteModel>(query);
        }

        public bool UpdateUsuario(ClienteModel model)
        {
            string query = $"UPDATE usuario SET nombre_usuario='{model.NombreUsuario}', apellido_usuario='{model.ApellidoUsuario}', tipo_documento='{model.TipoDocumento}', documento='{model.Documento}' WHERE documento='{model.Documento}'";
            Commands.ExecuteNonQuery(query);

            foreach (TelefonoClienteModel item in model.Telefonos)
            {
                query = $"UPDATE telefono_usuario SET telefono='{item.Telefono}', tipo='{item.Tipo}' WHERE id_usuario='{item.IdUsuario}'";
                Commands.ExecuteNonQuery(query);
            }
            return true;
        }

        public bool DeleteUser (string id)
        {
            string query = $"DELETE FROM usuario WHERE documento = '{id}';";
            return Commands.ExecuteNonQuery(query);
        }

        public List<ClienteModel> GetClientes()
        {
            string  query = $"SELECT * FROM usuario;";
            var ClienteList = Commands.Query<ClienteModel>(query);
            
            foreach(var item in ClienteList)
            {
                item.Telefonos = GetTelefonoClientes(item.IdUsuario);
            }
            return ClienteList;
        }

        public List<TelefonoClienteModel> GetTelefonoClientes(string id)
        {
            string query = $"SELECT id_usuario, telefono, tipo FROM telefono_usuario WHERE id_usuario= '{id}';";
            return Commands.Query<TelefonoClienteModel>(query);
        }

        public List<TelefonoClienteModel> GetTelefonoClientesDataSource(string id)
        {
            string query = $"SELECT telefono, tipo FROM telefono_usuario WHERE id_usuario= '{id}';";
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
                        cliente.TipoDocumento = reader["tipo_doc"].ToString();
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