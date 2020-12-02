using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Pabo.Calendar;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaCita.Utils;

namespace AgendaCita
{
    public partial class FrmCita : Form, IContract
    {
        public FrmCita()
        {
            InitializeComponent();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            new FrmConsultaCliente(this)
            {
                Visible = true
            };
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            new FrmConsultaProfesional(this)
            {
                Visible = true
            };
        }

        public void Execute (IModel model)
        {

        }
    }

}
