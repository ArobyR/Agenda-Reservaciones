using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaCita.Utils;

namespace AgendaCita.Models
{
    public class ProfesionalModel : IModel
    {
        public string IdProfesional { get; set; }
        public int IdProfesion { get; set; }
        public string NombreProfesional { get; set; }
        public string ApellidoProfesional { get; set; }
        public string Profesion { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public List<TelefonoProfesionalModel> Telefonos { get; set; }
        public Tipos Tipo { get; set; } = Tipos.PROFESIONAL;
    }
}
