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
        // esta realizando alguna forma de trabajo como insertar, eliminar y etc..

        public bool InsertUsuario (ClienteModel model)
        {
            //Guid IdUsuarioGuid = new Guid(); guid = Guid.NewGuid("N").Substring(0, 15);
            string IdUsuarioGuid = Guid.NewGuid().ToString();
            model.IdUsuario = IdUsuarioGuid.ToString();
            string query = $@"INSERT INTO usuario (id_usuario, nombre_usuario, apellido_usuario, tipo_doc, documento)
                             VALUES ('{model.IdUsuario}', '{model.NombreUsuario}', '{model.ApellidoUsuario}', '{model.TipoDoc}', '{model.Documento}')";
            
            Commands.ExecuteNonQuery(query);

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
            string query = $@"SELECT id_usuario, nombre_usuario, apellido_usuario, tipo_doc, documento FROM usuario WHERE documento = '{model.Documento}' LIMIT 1";

            return Commands.Query<ClienteModel>(query);
        }

        public bool Update(ClienteModel model)
        {
            string query = "";

            return Commands.ExecuteNonQuery(query);
        }

        public bool DeleteUser (string id)
        {
            // good think
            string query = $"DELETE FROM usuario WHERE documento = '{id}'";
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