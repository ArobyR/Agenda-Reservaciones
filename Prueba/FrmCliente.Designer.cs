namespace AgendaCita
{
    partial class FrmCliente
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtDocumentoUsuario = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbDisponibilidadProf = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.cmbDiaDisponibilidadProf = new System.Windows.Forms.ComboBox();
            this.cmbHoraDisponibilidadProf = new System.Windows.Forms.ComboBox();
            this.btnCrearCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 351);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(725, 224);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(28, 68);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(124, 68);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtApellidoUsuario.Location = new System.Drawing.Point(124, 104);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtApellidoUsuario.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApellido.Location = new System.Drawing.Point(28, 111);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoDocumento.Location = new System.Drawing.Point(28, 153);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(73, 17);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Doc.:";
            // 
            // txtDocumentoUsuario
            // 
            this.txtDocumentoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDocumentoUsuario.Location = new System.Drawing.Point(124, 183);
            this.txtDocumentoUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtDocumentoUsuario.Name = "txtDocumentoUsuario";
            this.txtDocumentoUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtDocumentoUsuario.TabIndex = 9;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(124, 145);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(201, 25);
            this.cmbTipoDocumento.TabIndex = 10;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDocumento.Location = new System.Drawing.Point(28, 187);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(84, 16);
            this.lblDocumento.TabIndex = 11;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(401, 72);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox5.Location = new System.Drawing.Point(494, 68);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 23);
            this.textBox5.TabIndex = 13;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnIngresar.Location = new System.Drawing.Point(166, 300);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 41);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnActualizar.Location = new System.Drawing.Point(313, 300);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 41);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.Location = new System.Drawing.Point(459, 300);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 41);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(594, 300);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 41);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(0, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(60, 45);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbDisponibilidadProf
            // 
            this.cmbDisponibilidadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbDisponibilidadProf.FormattingEnabled = true;
            this.cmbDisponibilidadProf.Location = new System.Drawing.Point(494, 108);
            this.cmbDisponibilidadProf.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDisponibilidadProf.Name = "cmbDisponibilidadProf";
            this.cmbDisponibilidadProf.Size = new System.Drawing.Size(201, 25);
            this.cmbDisponibilidadProf.TabIndex = 19;
            // 
            // lblProfesional
            // 
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfesional.Location = new System.Drawing.Point(401, 112);
            this.lblProfesional.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(83, 16);
            this.lblProfesional.TabIndex = 20;
            this.lblProfesional.Text = "Profesional:";
            // 
            // lblHorario
            // 
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHorario.Location = new System.Drawing.Point(401, 187);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(66, 16);
            this.lblHorario.TabIndex = 21;
            this.lblHorario.Text = "Horarios:";
            // 
            // lblDias
            // 
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDias.Location = new System.Drawing.Point(401, 148);
            this.lblDias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(33, 16);
            this.lblDias.TabIndex = 22;
            this.lblDias.Text = "Dia:";
            // 
            // cmbDiaDisponibilidadProf
            // 
            this.cmbDiaDisponibilidadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbDiaDisponibilidadProf.FormattingEnabled = true;
            this.cmbDiaDisponibilidadProf.Location = new System.Drawing.Point(494, 148);
            this.cmbDiaDisponibilidadProf.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDiaDisponibilidadProf.Name = "cmbDiaDisponibilidadProf";
            this.cmbDiaDisponibilidadProf.Size = new System.Drawing.Size(201, 25);
            this.cmbDiaDisponibilidadProf.TabIndex = 23;
            // 
            // cmbHoraDisponibilidadProf
            // 
            this.cmbHoraDisponibilidadProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbHoraDisponibilidadProf.FormattingEnabled = true;
            this.cmbHoraDisponibilidadProf.Location = new System.Drawing.Point(494, 187);
            this.cmbHoraDisponibilidadProf.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHoraDisponibilidadProf.Name = "cmbHoraDisponibilidadProf";
            this.cmbHoraDisponibilidadProf.Size = new System.Drawing.Size(201, 25);
            this.cmbHoraDisponibilidadProf.TabIndex = 24;
            // 
            // btnCrearCita
            // 
            this.btnCrearCita.Location = new System.Drawing.Point(31, 300);
            this.btnCrearCita.Name = "btnCrearCita";
            this.btnCrearCita.Size = new System.Drawing.Size(101, 41);
            this.btnCrearCita.TabIndex = 25;
            this.btnCrearCita.Text = "Crear";
            this.btnCrearCita.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 575);
            this.Controls.Add(this.btnCrearCita);
            this.Controls.Add(this.cmbHoraDisponibilidadProf);
            this.Controls.Add(this.cmbDiaDisponibilidadProf);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.cmbDisponibilidadProf);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.txtDocumentoUsuario);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.btnCerrar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumentoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbDisponibilidadProf;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.ComboBox cmbDiaDisponibilidadProf;
        private System.Windows.Forms.ComboBox cmbHoraDisponibilidadProf;
        private System.Windows.Forms.Button btnCrearCita;
    }
}