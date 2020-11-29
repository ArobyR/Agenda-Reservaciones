﻿using MySql.Data.MySqlClient;
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
        MySqlConnection cn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;

        public bool InsertProfesional(ProfesionalModel model)
        {
            string IdProfesionalGuid = Guid.NewGuid().ToString("N");
            model.IdProfesional = IdProfesionalGuid;

            string query = $@"INSERT INTO profesional(id_profesional, , nombre_profesional, apellido_profesional, tipo_documento, documento, profesion)
                VALUES('{model.IdProfesional}', '{model.NombreProfesional}', '{model.ApellidoProfesional}', '{model.TipoDocumento}', '{model.Documento}', '{model.IdProfesion}')";
         
            Commands.ExecuteNonQuery(query);

            foreach(TelefonoProfesionalModel item in model.Telefonos)
            {
                query = $"INSERT INTO telefono_profesional(id_profesional, numero, tipo) VALUES ('{model.IdProfesional}', '{item.Telefono}', '{item.Tipo}')";
                Commands.ExecuteNonQuery(query);
            }

            return true;
        }
        public bool Update(ProfesionalModel model)
        {
            string query = "";

            return Commands.ExecuteNonQuery(query);
        }

        public bool Delete(string id)
        {
            string query = $"DELETE FROM profesional WHERE id={id}";
            return Commands.ExecuteNonQuery(query);
        }


        public List<ProfesionalModel> Get(string documento = "None")
        {
            string query = $"SELECT * FROM profesional";

            if (documento != "None")
                query += $" WHERE documento ={documento}";

            return Commands.Query<ProfesionalModel>(query);
        }

        public List<TelefonoProfesionalModel> GetTelefonoProfesional(int id)
        {
            string query = $"SELECT id_profesional, tipo, numero FROM telefono_profesional WHERE id_profesional= {id}";
            return Commands.Query<TelefonoProfesionalModel>(query);
        }

        public List<DisponibilidadProfesionalModel> GetDisponibilidadProfesional(int id, int dia = -1)
        {
            string query = $"SELECT * FROM disponibilidad WHERE id_profesional = {id}";
            if (dia >= 0)
                query = query + $" AND id_dia = {dia}";

            return Commands.Query<DisponibilidadProfesionalModel>(query);
        }

    }
}
