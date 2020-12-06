using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCita.Models;
using AgendaCita.DAO;

namespace AgendaCita.DAO
{
    class CitaDAO
    {
        public bool Insert(CitaModel model)
        {
            string query = $"INSERT INTO consulta (id_profesional, id_usuario, id_dia, estado)" +
                           $"VALUES('{model.IdProfesional}','{model.IdUsuario}','{model.IdDia}', '{model.Estado=1}')";

            return Commands.ExecuteNonQuery(query);
        }

        public bool CancelarCita(CitaModel model)
        {
            string query = $"";

            return Commands.ExecuteNonQuery(query);
        }


        public List<CitaModel> GetDisponibilidadProfesionalPorFecha(string id)
        {
            string query = $"SELECT * FROM consulta WHERE id_profesional= '{id}'";
            return Commands.Query<CitaModel>(query);
        }
    }
}
