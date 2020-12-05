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
                           $"VALUES('{model.IdProfesional}','{model.IdUsuario}','{model.IdDia}', '{1}')";

            return Commands.ExecuteNonQuery(query);
        }

        public bool CancelarCita(CitaModel model)
        {
            string query = $"";

            return Commands.ExecuteNonQuery(query);
        }


        public List<CitaModel> GetDisponibilidadProfesionalPorFecha(string id, string date)
        {
            string query = $"SELECT * FROM consulta WHERE id_profesional= '{id}' and fecha_cita='{date}'";
            return Commands.Query<CitaModel>(query);
        }
    }
}
