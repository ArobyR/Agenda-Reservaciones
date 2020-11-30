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
    public partial class FrmCliente : Form
    {
        ClienteDAO ClienteDao = new ClienteDAO();
       // DataTable ClienteDatos;
       

        public FrmCliente()
        {
            InitializeComponent();

            //List<ClienteModel> lists = ClienteDao.GetClientes();
        }

        private void btnCerrarMenuUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            ClienteModel model = new ClienteModel();
            model.NombreUsuario = txtNombreUsuario.Text;
            model.ApellidoUsuario = txtApellidoUsuario.Text;
            model.TipoDoc = cmbTipoDocumento.SelectedItem.ToString();
            model.Documento = txtDocumentoUsuario.Text;

            model.Telefonos = new List<TelefonoClienteModel>(); 

            foreach (DataGridViewRow item in dgvTelefono.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                var telefono = new TelefonoClienteModel(); // propiedades del modelo
                telefono.Tipo = item.Cells[0].Value.ToString();
                telefono.Telefono = item.Cells[1].Value.ToString(); // numero de telefono
                model.Telefonos.Add(telefono);  // agregando propiedades 
            }
            // tienes que modificar algunas cosas, validacion de que se ha insertado correctamente
            // validacion de campos
            if (ClienteDao.InsertUsuario(model)) 
            {
                MessageBox.Show("Registro realizado correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Su consulta ha fallado.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string value = txtDocumentoUsuario.Text;
            List<ClienteModel> Lista = ClienteDao.ReadUsuario(value);

            if (Lista != null)
            {

                txtNombreUsuario.Text = Lista.ToArray().ToString(); ;
                //txtApellidoUsuario.Text = Lista[2].ToString();
                //cmbTipoDocumento.Text = Lista[3].ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClienteModel model = new ClienteModel();
            model.NombreUsuario = txtNombreUsuario.Text;
            model.ApellidoUsuario = txtApellidoUsuario.Text;
            model.TipoDoc = cmbTipoDocumento.SelectedItem.ToString();
            model.Documento = txtDocumentoUsuario.Text;

            model.Telefonos = new List<TelefonoClienteModel>();

            foreach (DataGridViewRow item in dgvTelefono.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    continue;
                }
                var telefono = new TelefonoClienteModel(); 
                telefono.Tipo = item.Cells[0].Value.ToString();
                telefono.Telefono = item.Cells[1].Value.ToString(); 
                model.Telefonos.Add(telefono);  
            }
            if (ClienteDao.UpdateUsuario(model))
            {
                MessageBox.Show("Registro actualizado con exito.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Su consulta ha fallado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDocumentoUsuario.Text == "")
            {
                MensajesInfaz("Relleno todos los campos", "Red");
                MessageBox.Show("Rellene todos los campos... Joder!");
                return;
            }
     
            string DocumentoUsuario = txtDocumentoUsuario.Text;
            if(ClienteDao.DeleteUser(DocumentoUsuario))
            {
                MessageBox.Show("Eliminado correctamente.");
                LimpiarCampos();
            }
            else if (!ClienteDao.DeleteUser(DocumentoUsuario))
            {
                MensajesInfaz("Dato no encontrado!", "Red");
                MessageBox.Show("Dato no encontrado.");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtApellidoUsuario.Text = "";
            txtDocumentoUsuario.Text = "";
            cmbTipoDocumento.Text = "";
            dgvTelefono.Rows.Clear();
        }

        private void ValidacionDeCampos ()
        {

        }

        private void MensajesInfaz(string Mensaje, string color)
        {
            lblMensaje.Text = Mensaje; 
            if(color == "Red")
            {
                lblMensaje.ForeColor = Color.Red;
            }
            else
            {
                lblMensaje.ForeColor = Color.Green;
            }
            
        }

        private void btnCargarInformacion_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DgvUsuario.DataSource = ClienteDao.GetClientes();
            DgvUsuario.Columns[0].Visible = false;
            DgvUsuario.Columns[1].HeaderText = "Nombre";
            DgvUsuario.Columns[2].HeaderText = "Apellido";
            DgvUsuario.Columns[3].HeaderText = "Tipo de Documento";
            DgvUsuario.Columns[4].HeaderText = "Documento";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = DgvUsuario.CurrentRow.Cells[1].Value.ToString();
            txtApellidoUsuario.Text = DgvUsuario.CurrentRow.Cells[2].Value.ToString();
            cmbTipoDocumento.Text = DgvUsuario.CurrentRow.Cells[3].Value.ToString();
            txtDocumentoUsuario.Text = DgvUsuario.CurrentRow.Cells[4].Value.ToString();

            string value = DgvUsuario.CurrentRow.Cells[0].Value.ToString();

            List<TelefonoClienteModel> Lista = ClienteDao.GetTelefonoClientesDataSource(value);
            
            dgvTelefono.DataSource = ClienteDao.GetTelefonoClientesDataSource(value);
            dgvTelefono.Columns[0].Visible = false;

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
