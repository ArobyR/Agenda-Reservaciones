using System;
using AgendaCita.DAO;
using AgendaCita.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaCita
{
    public partial class FrmProfesional : Form
    {
        ProfesionalDAO ProfesionalDao = new ProfesionalDAO();
        public FrmProfesional()
        {
            InitializeComponent();
        }

        private void btnExitMenuProfesional_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearProfesional_Click(object sender, EventArgs e)
        {
            ProfesionalModel model = new ProfesionalModel();
            model.NombreProfesional = txtNombreProfesional.Text;
            model.ApellidoProfesional = txtApellidoProfesional.Text;
            model.TipoDocumento = cmbTipoDocumentoProfesional.SelectedItem.ToString();
            model.Documento = txtDocumentoProfesional.Text;

            model.Telefonos = new List<TelefonoProfesionalModel>();


        }
    }
}
