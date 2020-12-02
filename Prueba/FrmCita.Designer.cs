
namespace AgendaCita
{
    partial class FrmCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCita));
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.lblTituloCitas = new System.Windows.Forms.Label();
            this.Disponibilidad_Calendar_Prof = new Pabo.Calendar.MonthCalendar();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblNombreProfesional = new System.Windows.Forms.Label();
            this.lblProfesionProfesional = new System.Windows.Forms.Label();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVentana.Location = new System.Drawing.Point(0, 1);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(60, 45);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.Text = "X";
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // lblTituloCitas
            // 
            this.lblTituloCitas.AutoSize = true;
            this.lblTituloCitas.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCitas.Location = new System.Drawing.Point(318, 19);
            this.lblTituloCitas.Name = "lblTituloCitas";
            this.lblTituloCitas.Size = new System.Drawing.Size(64, 27);
            this.lblTituloCitas.TabIndex = 30;
            this.lblTituloCitas.Text = "Citas";
            // 
            // Disponibilidad_Calendar_Prof
            // 
            this.Disponibilidad_Calendar_Prof.ActiveMonth.Month = 11;
            this.Disponibilidad_Calendar_Prof.ActiveMonth.Year = 2020;
            this.Disponibilidad_Calendar_Prof.Culture = new System.Globalization.CultureInfo("en-US");
            this.Disponibilidad_Calendar_Prof.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Disponibilidad_Calendar_Prof.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Disponibilidad_Calendar_Prof.Header.TextColor = System.Drawing.Color.White;
            this.Disponibilidad_Calendar_Prof.ImageList = null;
            this.Disponibilidad_Calendar_Prof.Location = new System.Drawing.Point(74, 233);
            this.Disponibilidad_Calendar_Prof.MaxDate = new System.DateTime(2030, 11, 27, 18, 41, 18, 174);
            this.Disponibilidad_Calendar_Prof.MinDate = new System.DateTime(2010, 11, 27, 18, 41, 18, 174);
            this.Disponibilidad_Calendar_Prof.Month.BackgroundImage = null;
            this.Disponibilidad_Calendar_Prof.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Disponibilidad_Calendar_Prof.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Disponibilidad_Calendar_Prof.Name = "Disponibilidad_Calendar_Prof";
            this.Disponibilidad_Calendar_Prof.Size = new System.Drawing.Size(295, 219);
            this.Disponibilidad_Calendar_Prof.TabIndex = 31;
            this.Disponibilidad_Calendar_Prof.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Disponibilidad_Calendar_Prof.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Disponibilidad_Calendar_Prof.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.Disponibilidad_Calendar_Prof_DaySelected);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(178, 58);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(122, 34);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfesional.Image")));
            this.btnBuscarProfesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProfesional.Location = new System.Drawing.Point(497, 58);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(122, 34);
            this.btnBuscarProfesional.TabIndex = 33;
            this.btnBuscarProfesional.Text = "Buscar";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(71, 58);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 34;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(71, 111);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(108, 18);
            this.lblNombreCliente.TabIndex = 35;
            this.lblNombreCliente.Text = "Nombre cliente";
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Location = new System.Drawing.Point(71, 155);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(54, 18);
            this.lblCedulaCliente.TabIndex = 36;
            this.lblCedulaCliente.Text = "Cedula";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(375, 58);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(87, 18);
            this.lblProfesional.TabIndex = 37;
            this.lblProfesional.Text = "Profesional:";
            // 
            // lblNombreProfesional
            // 
            this.lblNombreProfesional.AutoSize = true;
            this.lblNombreProfesional.Location = new System.Drawing.Point(375, 111);
            this.lblNombreProfesional.Name = "lblNombreProfesional";
            this.lblNombreProfesional.Size = new System.Drawing.Size(62, 18);
            this.lblNombreProfesional.TabIndex = 38;
            this.lblNombreProfesional.Text = "Nombre";
            // 
            // lblProfesionProfesional
            // 
            this.lblProfesionProfesional.AutoSize = true;
            this.lblProfesionProfesional.Location = new System.Drawing.Point(375, 155);
            this.lblProfesionProfesional.Name = "lblProfesionProfesional";
            this.lblProfesionProfesional.Size = new System.Drawing.Size(72, 18);
            this.lblProfesionProfesional.TabIndex = 39;
            this.lblProfesionProfesional.Text = "Profesion";
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(416, 233);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(75, 31);
            this.btnAgendarCita.TabIndex = 42;
            this.btnAgendarCita.Text = "Agendar";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Location = new System.Drawing.Point(416, 294);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(75, 31);
            this.btnCancelarCita.TabIndex = 43;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Location = new System.Drawing.Point(267, 486);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(55, 18);
            this.lblFechaCita.TabIndex = 44;
            this.lblFechaCita.Text = "Prueba";
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 611);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.lblProfesionProfesional);
            this.Controls.Add(this.lblNombreProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.lblCedulaCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.Disponibilidad_Calendar_Prof);
            this.Controls.Add(this.lblTituloCitas);
            this.Controls.Add(this.btnCerrarVentana);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCita";
            this.Text = "Citas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Label lblTituloCitas;
        private Pabo.Calendar.MonthCalendar Disponibilidad_Calendar_Prof;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblNombreProfesional;
        private System.Windows.Forms.Label lblProfesionProfesional;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Label lblFechaCita;
    }
}