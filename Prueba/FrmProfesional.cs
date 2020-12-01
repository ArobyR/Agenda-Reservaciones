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

        private void btnCargarInformacion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnModificarInformacion_Click(object sender, EventArgs e)
        {
            txtNombreProfesional.Text = dgvProfesional.CurrentRow.Cells[0].Value.ToString();
            txtApellidoProfesional.Text = dgvProfesional.CurrentRow.Cells[1].Value.ToString();
            cmbTipoDocumentoProfesional.Text = dgvProfesional.CurrentRow.Cells[3].Value.ToString();
            txtDocumentoProfesional.Text = dgvProfesional.CurrentRow.Cells[4].Value.ToString();

            // ------------------------------  traer dias de disponibilidad y telefonos ---------------------------
            string id_profesional = dgvProfesional.CurrentRow.Cells[1].Value.ToString();
            List<TelefonoProfesionalModel> Lista = ProfesionalDao.GetTelefonoProfesional(id_profesional);
            dgvTelefono.Columns[1].Visible = false;
            dgvTelefono.DataSource = ProfesionalDao.GetTelefonoProfesional(id_profesional);
        }

        private void LimpiarCampos()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtDocumentoProfesional.Text = "";
            cmbTipoDocumentoProfesional.Text = "";
            cmbProfesion.Text = "";
        }


        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProf_Click(object sender, EventArgs e)
        {
            // more validation
            if(txtDocumentoProfesional.Text == "" || txtDocumentoProfesional.Text == null)
            {
                MessageBox.Show("Rellene todos los campos... Joder!");
                return;
            }
            string DocumentoProfesional = txtDocumentoProfesional.Text;
            if(ProfesionalDao.DeleteProfesional(DocumentoProfesional))
            {
                MessageBox.Show("Eliminado correctamente.");
                LimpiarCampos();
            }
            else if (!ProfesionalDao.DeleteProfesional(DocumentoProfesional))
            {
                MessageBox.Show("Dato no encontrado");
            }
        }

        private void Checkboxes (CheckBox chk)
        {
            UnCheckAllCheckboxes(chk);

            if (chkLunVie.Checked)
            {
                chkLunes.Checked = true;
                chkMartes.Checked = true;
                chkMiercoles.Checked = true;
                chkJueves.Checked = true;
                chkViernes.Checked = true;
            }
        }

        private void chkLunVie_CheckedChanged(object sender, EventArgs e)
        {
            Checkboxes((CheckBox)sender);
        }

        private void UnCheckAllCheckboxes(CheckBox chk)
        {
            foreach (var item in pnlCheckboxes.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)item).Name.Equals(chk.Name))
                        continue;
                    ((CheckBox)item).Checked = false;
                }
            }
        }
    }
}