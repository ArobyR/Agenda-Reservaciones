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
            // Dispomibilidad profesional, validar si hay sino esta vacia la lista 
            List<int> Days = new List<int>(ValidationDisponibilildad());
            if (ProfesionalDao.InsertProfesional(model, Days))
            {
                MessageBox.Show("Registro realizado correctamente.");
                LimpiarCampos();
                CargarDatos();

            }
            else
            {
                MessageBox.Show("Su consulta ha fallado.");
            }
        }
        // return lista. First implementation
        private List<int> ValidationDisponibilildad()
        {
            List<int> ListaDiasDisponible = new List<int>();
            if (chkLunVie.Checked)
            {
                for (int i = 1; i <= 5; i++)
                {
                    ListaDiasDisponible.Add(i);
                }
                if (chkDomingo.Checked)
                    ListaDiasDisponible.Add(0);
                if (chkSabado.Checked)
                    ListaDiasDisponible.Add(6);

                return ListaDiasDisponible;
            }
            else
            {
                if (chkLunes.Checked)
                    ListaDiasDisponible.Add(1);
                if (chkMartes.Checked)
                    ListaDiasDisponible.Add(2);
                if (chkMiercoles.Checked)
                    ListaDiasDisponible.Add(3);
                if (chkJueves.Checked)
                    ListaDiasDisponible.Add(4);
                if (chkViernes.Checked)
                    ListaDiasDisponible.Add(5);
                if (chkSabado.Checked)
                    ListaDiasDisponible.Add(6);
                if (chkDomingo.Checked)
                    ListaDiasDisponible.Add(0);
    
                return ListaDiasDisponible;
            }
            //return null;
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
            txtNombreProfesional.Text = dgvProfesional.CurrentRow.Cells[2].Value.ToString();
            txtApellidoProfesional.Text = dgvProfesional.CurrentRow.Cells[3].Value.ToString();
            cmbTipoDocumentoProfesional.Text = dgvProfesional.CurrentRow.Cells[5].Value.ToString();
            txtDocumentoProfesional.Text = dgvProfesional.CurrentRow.Cells[6].Value.ToString();


            // ------------------------------  traer dias de disponibilidad y telefonos -------------------
            string id_profesional = dgvProfesional.CurrentRow.Cells[0].Value.ToString();
            List<TelefonoProfesionalModel> Lista = ProfesionalDao.GetTelefonoProfesional(id_profesional);
            
            foreach (TelefonoProfesionalModel item in Lista)
            {
                this.dgvTelefono.Rows.Add(new[] { item.Telefono, item.Tipo });
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtDocumentoProfesional.Text = "";
            txtNumeroProfesional.Text = "";
            cmbTipoDocumentoProfesional.Text = "";
            cmbProfesion.Text = "";
            cmbTipoTelefono.Text = "";
            dgvTelefono.Rows.Clear();

            chkLunes.Checked = false;
            chkMartes.Checked = false;
            chkMiercoles.Checked = false;
            chkJueves.Checked = false;
            chkViernes.Checked = false;
            chkSabado.Checked = false;
            chkDomingo.Checked = false;
            chkLunVie.Checked = false;
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
                CargarDatos();
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

        private void btnAgregarNumeroProfesional_Click(object sender, EventArgs e)
        {
            if(btnAgregarNumeroProfesional.Text.Equals("Agregar"))
            {
                foreach (DataGridViewRow item in dgvTelefono.Rows)
                {
                    if (txtNumeroProfesional.Text.Equals(item.Cells["Numero"].Value.ToString()))
                    {
                        return;
                    }
                    else if (txtNumeroProfesional.Text == "" || cmbTipoTelefono.Text == "") return;
                }

                this.dgvTelefono.Rows.Add(cmbTipoTelefono.Text, txtNumeroProfesional.Text);
                txtNumeroProfesional.Text = "";
                cmbTipoTelefono.Text = "";
            }
            if (btnAgregarNumeroProfesional.Text.Equals("Actualizar"))
            {
                dgvTelefono.Rows.RemoveAt(dgvTelefono.CurrentRow.Index);
                this.dgvTelefono.Rows.Add(cmbTipoTelefono.Text, txtNombreProfesional.Text);
                btnAgregarNumeroProfesional.Text = "Agregar";
            }
        }

        private void btnRemoverNumero_Click(object sender, EventArgs e)
        {
            if (dgvTelefono.Rows.Count != 0)
                dgvTelefono.Rows.RemoveAt(dgvTelefono.CurrentRow.Index);
        }

        private void dgvTelefono_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarNumeroProfesional.Text = "Actualizar";
            cmbTipoTelefono.Text = dgvTelefono.CurrentRow.Cells[0].Value.ToString();
            txtNumeroProfesional.Text = dgvTelefono.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnActualizarProf_Click(object sender, EventArgs e)
        {
            ProfesionalModel model = new ProfesionalModel();
            model.NombreProfesional = txtNombreProfesional.Text;
            model.ApellidoProfesional = txtApellidoProfesional.Text;
            model.TipoDocumento = cmbTipoDocumentoProfesional.Text;
            model.Documento = txtDocumentoProfesional.Text;
            model.IdProfesion = (int)cmbProfesion.SelectedValue;

            model.Telefonos = new List<TelefonoProfesionalModel>();
            foreach(DataGridViewRow item in dgvTelefono.Rows)
            {
                if (item.Cells[0] == null)
                    continue;

                var telefono = new TelefonoProfesionalModel();
                telefono.Telefono = item.Cells[1].Value.ToString();
                telefono.Tipo = item.Cells[0].Value.ToString();
                model.Telefonos.Add(telefono);
            }
            if (txtDocumentoProfesional.Text == "" || txtNombreProfesional.Text == "" || txtApellidoProfesional.Text == "")
            {
                MessageBox.Show("Rellene los campos... Joder!!!");
                return;
            }

            if (ProfesionalDao.UpdateProfesional(model))
            {
                MessageBox.Show("Registro actualizado con exito.");
                LimpiarCampos();
                CargarDatos();
            }

            else
            {
                MessageBox.Show("Su consulta ha fallado.");
            }
        }
    }
}