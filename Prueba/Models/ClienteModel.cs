using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCita.Models
{
    public class ClienteModel
    {
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string TipoDocumento { get; set; } /* Tipo documento */
        public string Documento { get; set; }

        public List<TelefonoClienteModel> Telefonos { get; set; }
    }
}
