using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCita.Models
{
    class CitaModel
    {
        public string IdConsulta { get; set; }
        public string IdUsuario { get; set; }
        public string IdProfesional { get; set; }
        public int IdDia { get; set; }
        public int Estado { get; set; }
    }
}
