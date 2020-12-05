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
    public partial class FrmConsultaProfesional : Form
    {
        DataTable data = new DataTable();
        private IContract _Contract;

        public FrmConsultaProfesional(IContract Contract)
        {
            InitializeComponent();

            this._Contract = Contract;

            data = new ProfesionalDAO().GetProfesional().ToDataTable();

            dgvProfesional.DataSource = data;
            dgvProfesional.Columns[0].Visible = false;
            dgvProfesional.Columns[1].Visible = false;
            dgvProfesional.Columns[2].HeaderText = "Nombre";
            dgvProfesional.Columns[3].HeaderText = "Apellido";
            dgvProfesional.Columns[4].HeaderText = "Profesion x";
            dgvProfesional.Columns[5].HeaderText = "Tipo de Documento";
            dgvProfesional.Columns[6].HeaderText = "Documento";
        }

        private void txtProfesional_TextChanged(object sender, EventArgs e)
        {
            data.DefaultView.RowFilter = $"NombreProfesional LIKE '%{txtProfesional.Text}%' OR ApellidoProfesional LIKE '%{txtProfesional.Text}%' OR Documento like '%{txtProfesional.Text}%'";

        }

        private void dgvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_Contract != null)
            {
                _Contract.Execute(new ProfesionalModel()
                {
                    IdProfesional = Convert.ToString(dgvProfesional.CurrentRow.Cells["IdProfesional"].Value),
                    NombreProfesional = dgvProfesional.CurrentRow.Cells["NombreProfesional"].Value.ToString(),
                    ApellidoProfesional = dgvProfesional.CurrentRow.Cells["ApellidoProfesional"].Value.ToString(),
                    Documento = dgvProfesional.CurrentRow.Cells["Documento"].Value.ToString(),
                    Profesion = "Profesion x"
                });
                Close();
            }
        }

    }
}
