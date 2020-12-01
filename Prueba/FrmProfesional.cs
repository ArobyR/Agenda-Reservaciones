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
            List<ProfesionProfesionalModel> lista = ProfesionalDao.GetProfesiones();
            cmbProfesion.DataSource = ProfesionalDao.GetProfesiones();
            cmbProfesion.ValueMember = "IdProfesion";
            cmbProfesion.DisplayMember = "NombreProfesion";    
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
            model.IdProfesion = (int) cmbProfesion.SelectedValue; 

            model.Telefonos = new List<TelefonoProfesionalModel>();

            foreach(DataGridViewRow item in dgvTelefono.Rows)
            {
                if(item.Cells[0].Value == null)
                {
                    continue;
                }
                var telefono = new TelefonoProfesionalModel();
                telefono.Tipo = item.Cells[0].Value.ToString();
                telefono.Telefono = item.Cells[1].Value.ToString();
                model.Telefonos.Add(telefono);
            }

            if(ProfesionalDao.InsertProfesional(model))
            {
                MessageBox.Show("Registro realizado correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Su consulta ha fallado.");

            }
        }

        private void CargarDatos()
        {
            dgvProfesional.DataSource = ProfesionalDao.GetProfesional();
            dgvProfesional.Columns[0].Visible = false;
            dgvProfesional.Columns[1].Visible = false;
            dgvProfesional.Columns[2].HeaderText = "Nombre";
            dgvProfesional.Columns[3].HeaderText = "Apellido";
            dgvProfesional.Columns[5].HeaderText = "Tipo de Documento";
            dgvProfesional.Columns[6].HeaderText = "Documento";
            dgvProfesional.Columns[4].HeaderText = "Profesion";
        }

        private void LimpiarCampos()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtDocumentoProfesional.Text = "";
            cmbTipoDocumentoProfesional.Text = "";
            cmbProfesion.Text = "";
        }

        private void btnCargarInformacion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProf_Click(object sender, EventArgs e)
        {

        }
    }
}
