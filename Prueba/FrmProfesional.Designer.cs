namespace AgendaCita
{
    partial class FrmProfesional
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
            this.btnExitMenuProfesional = new System.Windows.Forms.Button();
            this.lblNombreProf = new System.Windows.Forms.Label();
            this.lblApellidoProf = new System.Windows.Forms.Label();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.txtApellidoProfesional = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblHoraDeInicio = new System.Windows.Forms.Label();
            this.lblHoraDelFinal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblDiaDisponible = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrearProfesional = new System.Windows.Forms.Button();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.btnActualizarProf = new System.Windows.Forms.Button();
            this.btnEliminarProf = new System.Windows.Forms.Button();
            this.btnLimpiarSubMProf = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumentoProfesional = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoProfesional = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitMenuProfesional
            // 
            this.btnExitMenuProfesional.BackColor = System.Drawing.Color.Red;
            this.btnExitMenuProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenuProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMenuProfesional.ForeColor = System.Drawing.Color.White;
            this.btnExitMenuProfesional.Location = new System.Drawing.Point(1, 0);
            this.btnExitMenuProfesional.Margin = new System.Windows.Forms.Padding(5);
            this.btnExitMenuProfesional.Name = "btnExitMenuProfesional";
            this.btnExitMenuProfesional.Size = new System.Drawing.Size(60, 45);
            this.btnExitMenuProfesional.TabIndex = 0;
            this.btnExitMenuProfesional.Text = "X";
            this.btnExitMenuProfesional.UseVisualStyleBackColor = false;
            this.btnExitMenuProfesional.Click += new System.EventHandler(this.btnExitMenuProfesional_Click);
            // 
            // lblNombreProf
            // 
            this.lblNombreProf.AutoSize = true;
            this.lblNombreProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombreProf.Location = new System.Drawing.Point(30, 50);
            this.lblNombreProf.Name = "lblNombreProf";
            this.lblNombreProf.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProf.TabIndex = 2;
            this.lblNombreProf.Text = "Nombre:";
            // 
            // lblApellidoProf
            // 
            this.lblApellidoProf.AutoSize = true;
            this.lblApellidoProf.Location = new System.Drawing.Point(30, 92);
            this.lblApellidoProf.Name = "lblApellidoProf";
            this.lblApellidoProf.Size = new System.Drawing.Size(62, 17);
            this.lblApellidoProf.TabIndex = 3;
            this.lblApellidoProf.Text = "Apellido:";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(394, 52);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(72, 17);
            this.lblProfesion.TabIndex = 4;
            this.lblProfesion.Text = "Profesion:";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Location = new System.Drawing.Point(98, 52);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(221, 23);
            this.txtNombreProfesional.TabIndex = 6;
            // 
            // txtApellidoProfesional
            // 
            this.txtApellidoProfesional.Location = new System.Drawing.Point(98, 89);
            this.txtApellidoProfesional.Name = "txtApellidoProfesional";
            this.txtApellidoProfesional.Size = new System.Drawing.Size(221, 23);
            this.txtApellidoProfesional.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(497, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 25);
            this.comboBox2.TabIndex = 10;
            // 
            // lblHoraDeInicio
            // 
            this.lblHoraDeInicio.AutoSize = true;
            this.lblHoraDeInicio.Location = new System.Drawing.Point(394, 91);
            this.lblHoraDeInicio.Name = "lblHoraDeInicio";
            this.lblHoraDeInicio.Size = new System.Drawing.Size(99, 17);
            this.lblHoraDeInicio.TabIndex = 12;
            this.lblHoraDeInicio.Text = "Hora de inicio:";
            // 
            // lblHoraDelFinal
            // 
            this.lblHoraDelFinal.AutoSize = true;
            this.lblHoraDelFinal.Location = new System.Drawing.Point(396, 129);
            this.lblHoraDelFinal.Name = "lblHoraDelFinal";
            this.lblHoraDelFinal.Size = new System.Drawing.Size(97, 17);
            this.lblHoraDelFinal.TabIndex = 13;
            this.lblHoraDelFinal.Text = "Hora de Final:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(497, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(497, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 25);
            this.comboBox3.TabIndex = 15;
            // 
            // lblDiaDisponible
            // 
            this.lblDiaDisponible.AutoSize = true;
            this.lblDiaDisponible.Location = new System.Drawing.Point(396, 170);
            this.lblDiaDisponible.Name = "lblDiaDisponible";
            this.lblDiaDisponible.Size = new System.Drawing.Size(33, 17);
            this.lblDiaDisponible.TabIndex = 16;
            this.lblDiaDisponible.Text = "Dia:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(497, 167);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(201, 25);
            this.comboBox4.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 285);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnCrearProfesional
            // 
            this.btnCrearProfesional.Location = new System.Drawing.Point(33, 283);
            this.btnCrearProfesional.Name = "btnCrearProfesional";
            this.btnCrearProfesional.Size = new System.Drawing.Size(101, 39);
            this.btnCrearProfesional.TabIndex = 19;
            this.btnCrearProfesional.Text = "Crear";
            this.btnCrearProfesional.UseVisualStyleBackColor = true;
            this.btnCrearProfesional.Click += new System.EventHandler(this.btnCrearProfesional_Click);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Location = new System.Drawing.Point(319, 283);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(101, 40);
            this.btnBuscarProfesional.TabIndex = 20;
            this.btnBuscarProfesional.Text = "Buscar";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProf
            // 
            this.btnActualizarProf.Location = new System.Drawing.Point(176, 284);
            this.btnActualizarProf.Name = "btnActualizarProf";
            this.btnActualizarProf.Size = new System.Drawing.Size(101, 39);
            this.btnActualizarProf.TabIndex = 21;
            this.btnActualizarProf.Text = "Actualizar";
            this.btnActualizarProf.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProf
            // 
            this.btnEliminarProf.Location = new System.Drawing.Point(459, 283);
            this.btnEliminarProf.Name = "btnEliminarProf";
            this.btnEliminarProf.Size = new System.Drawing.Size(101, 40);
            this.btnEliminarProf.TabIndex = 22;
            this.btnEliminarProf.Text = "Eliminar";
            this.btnEliminarProf.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarSubMProf
            // 
            this.btnLimpiarSubMProf.Location = new System.Drawing.Point(603, 283);
            this.btnLimpiarSubMProf.Name = "btnLimpiarSubMProf";
            this.btnLimpiarSubMProf.Size = new System.Drawing.Size(101, 40);
            this.btnLimpiarSubMProf.TabIndex = 23;
            this.btnLimpiarSubMProf.Text = "Limpiar";
            this.btnLimpiarSubMProf.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(314, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 27);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Profesionales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cargar Informacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(603, 228);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(95, 38);
            this.btnMostrarInformacion.TabIndex = 32;
            this.btnMostrarInformacion.Text = "Mostrar";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo De Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Documento:";
            // 
            // txtDocumentoProfesional
            // 
            this.txtDocumentoProfesional.Location = new System.Drawing.Point(127, 170);
            this.txtDocumentoProfesional.Name = "txtDocumentoProfesional";
            this.txtDocumentoProfesional.Size = new System.Drawing.Size(192, 23);
            this.txtDocumentoProfesional.TabIndex = 35;
            // 
            // cmbTipoDocumentoProfesional
            // 
            this.cmbTipoDocumentoProfesional.FormattingEnabled = true;
            this.cmbTipoDocumentoProfesional.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte"});
            this.cmbTipoDocumentoProfesional.Location = new System.Drawing.Point(177, 129);
            this.cmbTipoDocumentoProfesional.Name = "cmbTipoDocumentoProfesional";
            this.cmbTipoDocumentoProfesional.Size = new System.Drawing.Size(142, 25);
            this.cmbTipoDocumentoProfesional.TabIndex = 36;
            this.cmbTipoDocumentoProfesional.Text = "Cedula";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Telefono});
            this.dataGridView2.Location = new System.Drawing.Point(36, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(283, 67);
            this.dataGridView2.TabIndex = 37;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "Celular",
            "Residencial"});
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // dgvTelefonoProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 614);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbTipoDocumentoProfesional);
            this.Controls.Add(this.txtDocumentoProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiarSubMProf);
            this.Controls.Add(this.btnEliminarProf);
            this.Controls.Add(this.btnActualizarProf);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.btnCrearProfesional);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lblDiaDisponible);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHoraDelFinal);
            this.Controls.Add(this.lblHoraDeInicio);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtApellidoProfesional);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.lblApellidoProf);
            this.Controls.Add(this.lblNombreProf);
            this.Controls.Add(this.btnExitMenuProfesional);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dgvTelefonoProf";
            this.Text = "Profesional";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMenuProfesional;
        private System.Windows.Forms.Label lblNombreProf;
        private System.Windows.Forms.Label lblApellidoProf;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.TextBox txtApellidoProfesional;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblHoraDeInicio;
        private System.Windows.Forms.Label lblHoraDelFinal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblDiaDisponible;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrearProfesional;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.Button btnActualizarProf;
        private System.Windows.Forms.Button btnEliminarProf;
        private System.Windows.Forms.Button btnLimpiarSubMProf;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumentoProfesional;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoProfesional;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}