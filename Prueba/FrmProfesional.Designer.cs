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
            this.cmbTipoDocumentoProfesional = new System.Windows.Forms.ComboBox();
            this.dgvTelefono = new System.Windows.Forms.DataGridView();
            this.btnAgregarNumeroProfesional = new System.Windows.Forms.Button();
            this.btnRemoverNumero = new System.Windows.Forms.Button();
            this.lblTipoNumero = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtNumeroProfesional = new System.Windows.Forms.TextBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkLunVie = new System.Windows.Forms.CheckBox();
            this.txtDocumentoProfesional = new System.Windows.Forms.TextBox();
            this.pnlCheckboxes = new System.Windows.Forms.Panel();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefono)).BeginInit();
            this.pnlCheckboxes.SuspendLayout();
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
            this.lblDiaDisponible.Location = new System.Drawing.Point(396, 45);
            this.lblDiaDisponible.Name = "lblDiaDisponible";
            this.lblDiaDisponible.Size = new System.Drawing.Size(40, 17);
            this.lblDiaDisponible.TabIndex = 16;
            this.lblDiaDisponible.Text = "Dias:";
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.AllowUserToAddRows = false;
            this.dgvProfesional.AllowUserToDeleteRows = false;
            this.dgvProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProfesional.Location = new System.Drawing.Point(0, 354);
            this.dgvProfesional.Name = "dgvProfesional";
            this.dgvProfesional.ReadOnly = true;
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
            this.btnModificarInformacion.Click += new System.EventHandler(this.btnModificarInformacion_Click);
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
            this.dgvTelefono.AllowUserToAddRows = false;
            this.dgvTelefono.AllowUserToDeleteRows = false;
            this.dgvTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Numero});
            this.dgvTelefono.Location = new System.Drawing.Point(410, 179);
            this.dgvTelefono.Name = "dgvTelefono";
            this.dgvTelefono.ReadOnly = true;
            this.dgvTelefono.Size = new System.Drawing.Size(283, 67);
            this.dgvTelefono.TabIndex = 37;
            this.dgvTelefono.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefono_CellContentDoubleClick);
            // 
            // btnAgregarNumeroProfesional
            // 
            this.btnAgregarNumeroProfesional.Location = new System.Drawing.Point(464, 252);
            this.btnAgregarNumeroProfesional.Name = "btnAgregarNumeroProfesional";
            this.btnAgregarNumeroProfesional.Size = new System.Drawing.Size(81, 35);
            this.btnAgregarNumeroProfesional.TabIndex = 38;
            this.btnAgregarNumeroProfesional.Text = "Agregar";
            this.btnAgregarNumeroProfesional.UseVisualStyleBackColor = true;
            this.btnAgregarNumeroProfesional.Click += new System.EventHandler(this.btnAgregarNumeroProfesional_Click);
            // 
            // btnRemoverNumero
            // 
            this.btnRemoverNumero.Location = new System.Drawing.Point(584, 252);
            this.btnRemoverNumero.Name = "btnRemoverNumero";
            this.btnRemoverNumero.Size = new System.Drawing.Size(109, 35);
            this.btnRemoverNumero.TabIndex = 39;
            this.btnRemoverNumero.Text = "Remover Tel.";
            this.btnRemoverNumero.UseVisualStyleBackColor = true;
            this.btnRemoverNumero.Click += new System.EventHandler(this.btnRemoverNumero_Click);
            // 
            // lblTipoNumero
            // 
            this.lblTipoNumero.AutoSize = true;
            this.lblTipoNumero.Location = new System.Drawing.Point(407, 129);
            this.lblTipoNumero.Name = "lblTipoNumero";
            this.lblTipoNumero.Size = new System.Drawing.Size(40, 17);
            this.lblTipoNumero.TabIndex = 40;
            this.lblTipoNumero.Text = "Tipo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(553, 132);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 41;
            this.lblNumero.Text = "Numero:";
            // 
            // cmbTipoTelefono
            // 
            this.cmbTipoTelefono.FormattingEnabled = true;
            this.cmbTipoTelefono.Items.AddRange(new object[] {
            "Celular",
            "Residencial"});
            this.cmbTipoTelefono.Location = new System.Drawing.Point(410, 150);
            this.cmbTipoTelefono.Name = "cmbTipoTelefono";
            this.cmbTipoTelefono.Size = new System.Drawing.Size(121, 25);
            this.cmbTipoTelefono.TabIndex = 42;
            // 
            // txtNumeroProfesional
            // 
            this.txtNumeroProfesional.Location = new System.Drawing.Point(556, 152);
            this.txtNumeroProfesional.Name = "txtNumeroProfesional";
            this.txtNumeroProfesional.Size = new System.Drawing.Size(137, 23);
            this.txtNumeroProfesional.TabIndex = 43;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(3, 4);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(66, 21);
            this.chkLunes.TabIndex = 45;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(75, 5);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(70, 21);
            this.chkMartes.TabIndex = 47;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(151, 4);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(87, 21);
            this.chkMiercoles.TabIndex = 48;
            this.chkMiercoles.Text = "Miercoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(3, 32);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(72, 21);
            this.chkJueves.TabIndex = 49;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(82, 32);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(75, 21);
            this.chkViernes.TabIndex = 50;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(163, 32);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(76, 21);
            this.chkSabado.TabIndex = 51;
            this.chkSabado.Text = "Sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(3, 60);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(83, 21);
            this.chkDomingo.TabIndex = 52;
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkLunVie
            // 
            this.chkLunVie.AutoSize = true;
            this.chkLunVie.Location = new System.Drawing.Point(93, 60);
            this.chkLunVie.Name = "chkLunVie";
            this.chkLunVie.Size = new System.Drawing.Size(76, 21);
            this.chkLunVie.TabIndex = 53;
            this.chkLunVie.Text = "Lun-Vie";
            this.chkLunVie.UseVisualStyleBackColor = true;
            this.chkLunVie.CheckedChanged += new System.EventHandler(this.chkLunVie_CheckedChanged);
            // 
            // txtDocumentoProfesional
            // 
            this.txtDocumentoProfesional.Location = new System.Drawing.Point(121, 167);
            this.txtDocumentoProfesional.Name = "txtDocumentoProfesional";
            this.txtDocumentoProfesional.Size = new System.Drawing.Size(198, 23);
            this.txtDocumentoProfesional.TabIndex = 54;
            // 
            // pnlCheckboxes
            // 
            this.pnlCheckboxes.Controls.Add(this.chkLunes);
            this.pnlCheckboxes.Controls.Add(this.chkMartes);
            this.pnlCheckboxes.Controls.Add(this.chkLunVie);
            this.pnlCheckboxes.Controls.Add(this.chkMiercoles);
            this.pnlCheckboxes.Controls.Add(this.chkDomingo);
            this.pnlCheckboxes.Controls.Add(this.chkJueves);
            this.pnlCheckboxes.Controls.Add(this.chkSabado);
            this.pnlCheckboxes.Controls.Add(this.chkViernes);
            this.pnlCheckboxes.Location = new System.Drawing.Point(442, 41);
            this.pnlCheckboxes.Name = "pnlCheckboxes";
            this.pnlCheckboxes.Size = new System.Drawing.Size(248, 88);
            this.pnlCheckboxes.TabIndex = 55;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // FrmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 614);
            this.Controls.Add(this.pnlCheckboxes);
            this.Controls.Add(this.txtDocumentoProfesional);
            this.Controls.Add(this.txtNumeroProfesional);
            this.Controls.Add(this.cmbTipoTelefono);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipoNumero);
            this.Controls.Add(this.btnRemoverNumero);
            this.Controls.Add(this.btnAgregarNumeroProfesional);
            this.Controls.Add(this.dgvTelefono);
            this.Controls.Add(this.cmbTipoDocumentoProfesional);
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
            this.pnlCheckboxes.ResumeLayout(false);
            this.pnlCheckboxes.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTipoDocumentoProfesional;
        private System.Windows.Forms.DataGridView dgvTelefono;
        private System.Windows.Forms.Button btnAgregarNumeroProfesional;
        private System.Windows.Forms.Button btnRemoverNumero;
        private System.Windows.Forms.Label lblTipoNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbTipoTelefono;
        private System.Windows.Forms.TextBox txtNumeroProfesional;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkLunVie;
        private System.Windows.Forms.TextBox txtDocumentoProfesional;
        private System.Windows.Forms.Panel pnlCheckboxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}