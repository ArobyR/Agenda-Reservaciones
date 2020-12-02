using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCita.Models;

namespace AgendaCita.DAO
{
    class ProfesionalDAO
    {
        public bool InsertProfesional(ProfesionalModel model, List<int> Days)
        {
            string IdProfesionalGuid = Guid.NewGuid().ToString("N");
            model.IdProfesional = IdProfesionalGuid;

            string query = $@"INSERT INTO profesional(id_profesional, id_profesion, nombre_profesional, apellido_profesional, tipo_documento, documento)
                VALUES('{model.IdProfesional}','{model.IdProfesion}', '{model.NombreProfesional}', '{model.ApellidoProfesional}', '{model.TipoDocumento}', '{model.Documento}')";
         
            Commands.ExecuteNonQuery(query);

            foreach(TelefonoProfesionalModel item in model.Telefonos)
            {
                query = $"INSERT INTO telefono_profesional (id_profesional, telefono, tipo) VALUES ('{model.IdProfesional}', '{item.Telefono}', '{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }
            Days.Sort();

            //foreach(DisponibilidadProfesionalModel item in model.)
            foreach(var dias in Days)
            {
                query = $"INSERT INTO disponibilidad(id_profesional, id_dia) VALUES('{model.IdProfesional}', '{dias}')";
                Commands.ExecuteNonQuery(query);
            }
            return true;
        }

        public bool Update(ProfesionalModel model)
        {
            string query = "";

            return Commands.ExecuteNonQuery(query);
        }

        public bool DeleteProfesional(string id)
        {
            string query = $"DELETE FROM profesional WHERE documento='{id}'";
            return Commands.ExecuteNonQuery(query);
        }

        public List<ProfesionalModel> Get(string documento = "None")
        {
            string query = $"SELECT * FROM profesional";

            if (documento != "None")
                query += $" WHERE documento ={documento}";

            return Commands.Query<ProfesionalModel>(query);
        }

        public List<ProfesionalModel> GetProfesional()
        {
            string query = $"SELECT * FROM profesional;";
            var ProfesionalList = Commands.Query<ProfesionalModel>(query);

            foreach (var item in ProfesionalList)
            {
                item.Telefonos = GetTelefonoProfesional(item.IdProfesional);
            }

            return ProfesionalList;
        }

        public List<ProfesionalModel> GetProfesionalProfesion()
        {
            string query = $@" SELECT prof.id_profesional,
                                      prof.id_profesion,
                                      prof.nombre_profesional, 
                                      prof.apellido_profesional,
                                      prof.tipo_documento, 
                                      prof.documento, 
                                      profesion.nombre_profesion 
                                FROM profesional AS prof 
                                INNER JOIN
                                      profesion 
                                ON 
                                      prof.id_profesion = profesion.id_profesion "; // inner join query
            var ProfesionalList = Commands.Query<ProfesionalModel>(query);

            return ProfesionalList;
        }

        public List<TelefonoProfesionalModel> GetTelefonoProfesional(string id)
        {
            string query = $"SELECT tipo, telefono FROM telefono_profesional WHERE id_profesional= '{id}'";
            return Commands.Query<TelefonoProfesionalModel>(query);
        }

        public List<DisponibilidadProfesionalModel> GetDisponibilidadProfesional(int id, int dia = -1)
        {
            string query = $"SELECT * FROM disponibilidad WHERE id_profesional = {id}";
            if (dia >= 0)
                query = query + $" AND id_dia = {dia}";

            return Commands.Query<DisponibilidadProfesionalModel>(query);
        }

        public List<ProfesionProfesionalModel> GetProfesiones()
        {
            string query = $"SELECT * FROM profesion";
            return Commands.Query<ProfesionProfesionalModel>(query);
        }
    }
}
