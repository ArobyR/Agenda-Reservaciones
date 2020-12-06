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
using Pabo.Calendar;

namespace AgendaCita
{

    public partial class FrmCita : Form, IContract
    {
        private string IdProfesional = "";
        private string IdUsuario = "";
        private DateItem[] dateItems;

        private ProfesionalDAO ProfesionalDao = new ProfesionalDAO();
        private CitaDAO citaDAO = new CitaDAO();

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
            if (model.Tipo == Tipos.CLIENTE)
            {
                var item = (ClienteModel)model;
                lblNombreCliente.Text = $"{item.NombreUsuario} {item.ApellidoUsuario}";
                lblCedulaCliente.Text = item.Documento;
                IdUsuario = Convert.ToString(item.IdUsuario);
            }
            else if (model.Tipo == Tipos.PROFESIONAL)
            {

                var item = (ProfesionalModel)model;
                IdProfesional = item.IdProfesional;
                lblNombreProfesional.Text = $"{item.NombreProfesional} {item.ApellidoProfesional}";
                lblProfesionProfesional.Text = item.Profesion;

                dateItems = new DateItem[366];

                var diasDisponibles = ProfesionalDao.GetDisponibilidadProfesional(IdProfesional);

                DiasNoLaborables();

                foreach (var itemDay in diasDisponibles)
                {
                    DiasLaborables(itemDay.IdDia);
                }

                Disponibilidad_Calendar_Prof.AddDateInfo(dateItems);
                Disponibilidad_Calendar_Prof.Refresh();

            }
        }

        private void DiasLaborables(int dia)
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var d = dt.AddDays(i);
                if (dateItems[i].Date == d)
                {
                    if (d.DayOfWeek == (DayOfWeek)dia)
                    {
                        var di = new DateItem();
                        di.Date = d;
                        di.BackColor1 = Color.Green;
                        dateItems[i] = di;
                    }
                }
            }
        }

        private void DiasNoLaborables()
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var di = new DateItem();
                di.Date = dt.AddDays(i);
                di.Enabled = false;
                dateItems[i] = di;

            }
        }
        private void Disponibilidad_Calendar_Prof_DaySelected(object sender, DaySelectedEventArgs e)
        {
            string[] m_daysSelected = e.Days;
            var fechaSeleccionadaDisponinilidad = citaDAO.GetDisponibilidadProfesionalPorFecha(IdProfesional);
            lblFechaCita.Text = m_daysSelected[0];

        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if (Disponibilidad_Calendar_Prof.SelectedDates.Count == 0)
            {
                MessageBox.Show("Selecciona una fecha");
                return;
            }
            var result = citaDAO.Insert(new CitaModel()
            {
                IdUsuario = this.IdUsuario,
                IdProfesional = this.IdProfesional,
                IdDia = Convert.ToInt32(Disponibilidad_Calendar_Prof.SelectedDates[0].DayOfWeek)
                // estado
            });
            if(result)
                MessageBox.Show("Cita Generada Correctamente");
            else
                MessageBox.Show("Ocurrio un error inesperado");
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {

        }
    }

}
