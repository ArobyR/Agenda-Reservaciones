using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCita.Models
{
    class DisponibilidadProfesionalModel
    {
        public string IdProfesional { get; set; }
        public int IdDia { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
    }
}
