using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaCita.Utils;
using AgendaCita.Models;
using AgendaCita.DAO;

namespace AgendaCita
{
    public partial class FrmConsultaCliente : Form
    {
        DataTable data = new DataTable();
        private IContract _Contract;
        ClienteDAO ClienteDao = new ClienteDAO();


        public FrmConsultaCliente(IContract Contract)
        {
            InitializeComponent();
            
            this._Contract = Contract;
            dgvCliente.DataSource = ClienteDao.GetClientes();
            dgvCliente.Columns[0].Visible = false;
            dgvCliente.Columns[1].HeaderText = "Nombre";
            dgvCliente.Columns[2].HeaderText = "Apellido";
            dgvCliente.Columns[3].HeaderText = "Tipo de Documento";
            dgvCliente.Columns[4].HeaderText = "Documento";
        }

        private void txtFiltrarCliente_TextChanged(object sender, EventArgs e)
        {
            DataView dtv = data.DefaultView;
            dtv.RowFilter = $"nombre like '% {txtFiltrarCliente.Text} %' OR apellido LIKE '%{txtFiltrarCliente.Text}%' OR Documento = '%{txtFiltrarCliente.Text}%'";
            dgvCliente.DataSource = dtv;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_Contract != null)
            {
                _Contract.Execute(new ClienteModel() {
                    IdUsuario = Convert.ToString(dgvCliente.CurrentRow.Cells["IdUsuario"].Value),
                    NombreUsuario = dgvCliente.CurrentRow.Cells["NombreUsuario"].Value.ToString(),
                    ApellidoUsuario = dgvCliente.CurrentRow.Cells["ApellidoUsuario"].Value.ToString(),
                    Documento = dgvCliente.CurrentRow.Cells["Documento"].Value.ToString()
                });
            Close();
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
