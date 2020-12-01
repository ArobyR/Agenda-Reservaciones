using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaCita.Models;

namespace AgendaCita
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            //panelSideMenu.Visible = false;
            panelSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
            
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(); // close other submenus
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        // open only instance or one form in simple words 
        private Form activateForm = null; // posible bug for the form
        private void openChilForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm.Dispose();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // add form to panel
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnSubUsuarios_Click(object sender, EventArgs e)
        {
            // code 
            openChilForm(new FrmCliente());
            hideSubMenu();
        }

        private void btnSubProfesionales_Click(object sender, EventArgs e)
        {
            openChilForm(new FrmProfesional());
            hideSubMenu();
        }

        private void btnExitAplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubMenuCitas_Click(object sender, EventArgs e)
        {
            openChilForm(new FrmCita());
            hideSubMenu();
        }
    }
}
