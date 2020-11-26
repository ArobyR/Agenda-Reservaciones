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
        //DataTable ClienteDatos;


        public FrmCliente()
        {
            InitializeComponent();
           
            //DgvUsuario.DataSource = ClienteDatos; // lo prodria hacer con el modelo?
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

            model.Telefonos = new List<TelefonoClienteModel>(); //Lista de objectos

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
            ClienteModel model = new ClienteModel();
            model.Documento = txtDocumentoUsuario.Text;
            
            var Lista = new List<ClienteModel>();

            //var ClienteList = new List<ClienteModel>();

            Lista = ClienteDao.ReadUsuario(model);
            if (Lista != null)
            {   // estoy leyendo objectos y no propriedades?
                txtNombreUsuario.Text = Lista[2].ToString();
                txtApellidoUsuario.Text = Lista[3].ToString();

            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

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
    }
}
