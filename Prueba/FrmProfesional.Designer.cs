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
            this.cmbProfesion = new System.Windows.Forms.ComboBox();
            this.lblDiaDisponible = new System.Windows.Forms.Label();
            this.dgvProfesional = new System.Windows.Forms.DataGridView();
            this.btnCrearProfesional = new System.Windows.Forms.Button();
            this.btnBuscarProfesional = new System.Windows.Forms.Button();
            this.btnActualizarProf = new System.Windows.Forms.Button();
            this.btnEliminarProf = new System.Windows.Forms.Button();
            this.btnLimpiarSubMProf = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargarInformacion = new System.Windows.Forms.Button();
            this.btnModificarInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumentoProfesional = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoProfesional = new System.Windows.Forms.ComboBox();
            this.dgvTelefono = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTipoNumero = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNumeroProfesional = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefono)).BeginInit();
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
            this.lblProfesion.Location = new System.Drawing.Point(30, 199);
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
            // cmbProfesion
            // 
            this.cmbProfesion.FormattingEnabled = true;
            this.cmbProfesion.Location = new System.Drawing.Point(120, 199);
            this.cmbProfesion.Name = "cmbProfesion";
            this.cmbProfesion.Size = new System.Drawing.Size(199, 25);
            this.cmbProfesion.TabIndex = 10;
            // 
            // lblDiaDisponible
            // 
            this.lblDiaDisponible.AutoSize = true;
            this.lblDiaDisponible.Location = new System.Drawing.Point(412, 45);
            this.lblDiaDisponible.Name = "lblDiaDisponible";
            this.lblDiaDisponible.Size = new System.Drawing.Size(40, 17);
            this.lblDiaDisponible.TabIndex = 16;
            this.lblDiaDisponible.Text = "Dias:";
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProfesional.Location = new System.Drawing.Point(0, 354);
            this.dgvProfesional.Name = "dgvProfesional";
            this.dgvProfesional.Size = new System.Drawing.Size(741, 260);
            this.dgvProfesional.TabIndex = 18;
            // 
            // btnCrearProfesional
            // 
            this.btnCrearProfesional.Location = new System.Drawing.Point(33, 307);
            this.btnCrearProfesional.Name = "btnCrearProfesional";
            this.btnCrearProfesional.Size = new System.Drawing.Size(81, 35);
            this.btnCrearProfesional.TabIndex = 19;
            this.btnCrearProfesional.Text = "Crear";
            this.btnCrearProfesional.UseVisualStyleBackColor = true;
            this.btnCrearProfesional.Click += new System.EventHandler(this.btnCrearProfesional_Click);
            // 
            // btnBuscarProfesional
            // 
            this.btnBuscarProfesional.Location = new System.Drawing.Point(249, 307);
            this.btnBuscarProfesional.Name = "btnBuscarProfesional";
            this.btnBuscarProfesional.Size = new System.Drawing.Size(81, 35);
            this.btnBuscarProfesional.TabIndex = 20;
            this.btnBuscarProfesional.Text = "Buscar";
            this.btnBuscarProfesional.UseVisualStyleBackColor = true;
            this.btnBuscarProfesional.Click += new System.EventHandler(this.btnBuscarProfesional_Click);
            // 
            // btnActualizarProf
            // 
            this.btnActualizarProf.Location = new System.Drawing.Point(141, 307);
            this.btnActualizarProf.Name = "btnActualizarProf";
            this.btnActualizarProf.Size = new System.Drawing.Size(81, 35);
            this.btnActualizarProf.TabIndex = 21;
            this.btnActualizarProf.Text = "Actualizar";
            this.btnActualizarProf.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProf
            // 
            this.btnEliminarProf.Location = new System.Drawing.Point(355, 307);
            this.btnEliminarProf.Name = "btnEliminarProf";
            this.btnEliminarProf.Size = new System.Drawing.Size(81, 35);
            this.btnEliminarProf.TabIndex = 22;
            this.btnEliminarProf.Text = "Eliminar";
            this.btnEliminarProf.UseVisualStyleBackColor = true;
            this.btnEliminarProf.Click += new System.EventHandler(this.btnEliminarProf_Click);
            // 
            // btnLimpiarSubMProf
            // 
            this.btnLimpiarSubMProf.Location = new System.Drawing.Point(464, 307);
            this.btnLimpiarSubMProf.Name = "btnLimpiarSubMProf";
            this.btnLimpiarSubMProf.Size = new System.Drawing.Size(81, 35);
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
            // btnCargarInformacion
            // 
            this.btnCargarInformacion.Location = new System.Drawing.Point(572, 307);
            this.btnCargarInformacion.Name = "btnCargarInformacion";
            this.btnCargarInformacion.Size = new System.Drawing.Size(137, 35);
            this.btnCargarInformacion.TabIndex = 31;
            this.btnCargarInformacion.Text = "Cargar Informacion";
            this.btnCargarInformacion.UseVisualStyleBackColor = true;
            this.btnCargarInformacion.Click += new System.EventHandler(this.btnCargarInformacion_Click);
            // 
            // btnModificarInformacion
            // 
            this.btnModificarInformacion.Location = new System.Drawing.Point(33, 252);
            this.btnModificarInformacion.Name = "btnModificarInformacion";
            this.btnModificarInformacion.Size = new System.Drawing.Size(81, 35);
            this.btnModificarInformacion.TabIndex = 32;
            this.btnModificarInformacion.Text = "Modificar";
            this.btnModificarInformacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo De Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Documento:";
            // 
            // txtDocumentoProfesional
            // 
            this.txtDocumentoProfesional.Location = new System.Drawing.Point(120, 164);
            this.txtDocumentoProfesional.Name = "txtDocumentoProfesional";
            this.txtDocumentoProfesional.Size = new System.Drawing.Size(199, 23);
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
            // dgvTelefono
            // 
            this.dgvTelefono.AllowUserToDeleteRows = false;
            this.dgvTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Telefono});
            this.dgvTelefono.Location = new System.Drawing.Point(426, 179);
            this.dgvTelefono.Name = "dgvTelefono";
            this.dgvTelefono.Size = new System.Drawing.Size(283, 67);
            this.dgvTelefono.TabIndex = 37;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 39;
            this.button2.Text = "Remover Tel.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTipoNumero
            // 
            this.lblTipoNumero.AutoSize = true;
            this.lblTipoNumero.Location = new System.Drawing.Point(423, 129);
            this.lblTipoNumero.Name = "lblTipoNumero";
            this.lblTipoNumero.Size = new System.Drawing.Size(40, 17);
            this.lblTipoNumero.TabIndex = 40;
            this.lblTipoNumero.Text = "Tipo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(569, 132);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 41;
            this.lblNumero.Text = "Numero:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Celular",
            "Residencial"});
            this.comboBox1.Location = new System.Drawing.Point(426, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 42;
            // 
            // txtNumeroProfesional
            // 
            this.txtNumeroProfesional.Location = new System.Drawing.Point(572, 152);
            this.txtNumeroProfesional.Name = "txtNumeroProfesional";
            this.txtNumeroProfesional.Size = new System.Drawing.Size(137, 23);
            this.txtNumeroProfesional.TabIndex = 43;
            // 
            // FrmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 614);
            this.Controls.Add(this.txtNumeroProfesional);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipoNumero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTelefono);
            this.Controls.Add(this.cmbTipoDocumentoProfesional);
            this.Controls.Add(this.txtDocumentoProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarInformacion);
            this.Controls.Add(this.btnCargarInformacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiarSubMProf);
            this.Controls.Add(this.btnEliminarProf);
            this.Controls.Add(this.btnActualizarProf);
            this.Controls.Add(this.btnBuscarProfesional);
            this.Controls.Add(this.btnCrearProfesional);
            this.Controls.Add(this.dgvProfesional);
            this.Controls.Add(this.lblDiaDisponible);
            this.Controls.Add(this.cmbProfesion);
            this.Controls.Add(this.txtApellidoProfesional);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.lblApellidoProf);
            this.Controls.Add(this.lblNombreProf);
            this.Controls.Add(this.btnExitMenuProfesional);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProfesional";
            this.Text = "Profesional";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefono)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbProfesion;
        private System.Windows.Forms.Label lblDiaDisponible;
        private System.Windows.Forms.DataGridView dgvProfesional;
        private System.Windows.Forms.Button btnCrearProfesional;
        private System.Windows.Forms.Button btnBuscarProfesional;
        private System.Windows.Forms.Button btnActualizarProf;
        private System.Windows.Forms.Button btnEliminarProf;
        private System.Windows.Forms.Button btnLimpiarSubMProf;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCargarInformacion;
        private System.Windows.Forms.Button btnModificarInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumentoProfesional;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoProfesional;
        private System.Windows.Forms.DataGridView dgvTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTipoNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNumeroProfesional;
    }
}