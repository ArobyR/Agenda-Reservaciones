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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblHoraDeInicio = new System.Windows.Forms.Label();
            this.lblHoraDelFinal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblDiaDisponible = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrearProfesional = new System.Windows.Forms.Button();
            this.btnIngresarProf = new System.Windows.Forms.Button();
            this.btnActualizarProf = new System.Windows.Forms.Button();
            this.btnEliminarProf = new System.Windows.Forms.Button();
            this.btnLimpiarSubMProf = new System.Windows.Forms.Button();
            this.dgvTelefonoProfesional = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonoProfesional)).BeginInit();
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
            this.lblNombreProf.Location = new System.Drawing.Point(30, 83);
            this.lblNombreProf.Name = "lblNombreProf";
            this.lblNombreProf.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProf.TabIndex = 2;
            this.lblNombreProf.Text = "Nombre:";
            // 
            // lblApellidoProf
            // 
            this.lblApellidoProf.AutoSize = true;
            this.lblApellidoProf.Location = new System.Drawing.Point(30, 125);
            this.lblApellidoProf.Name = "lblApellidoProf";
            this.lblApellidoProf.Size = new System.Drawing.Size(62, 17);
            this.lblApellidoProf.TabIndex = 3;
            this.lblApellidoProf.Text = "Apellido:";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(371, 83);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(72, 17);
            this.lblProfesion.TabIndex = 4;
            this.lblProfesion.Text = "Profesion:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 23);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(474, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 25);
            this.comboBox2.TabIndex = 10;
            // 
            // lblHoraDeInicio
            // 
            this.lblHoraDeInicio.AutoSize = true;
            this.lblHoraDeInicio.Location = new System.Drawing.Point(371, 125);
            this.lblHoraDeInicio.Name = "lblHoraDeInicio";
            this.lblHoraDeInicio.Size = new System.Drawing.Size(99, 17);
            this.lblHoraDeInicio.TabIndex = 12;
            this.lblHoraDeInicio.Text = "Hora de inicio:";
            // 
            // lblHoraDelFinal
            // 
            this.lblHoraDelFinal.AutoSize = true;
            this.lblHoraDelFinal.Location = new System.Drawing.Point(371, 168);
            this.lblHoraDelFinal.Name = "lblHoraDelFinal";
            this.lblHoraDelFinal.Size = new System.Drawing.Size(97, 17);
            this.lblHoraDelFinal.TabIndex = 13;
            this.lblHoraDelFinal.Text = "Hora de Final:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(474, 164);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 25);
            this.comboBox3.TabIndex = 15;
            // 
            // lblDiaDisponible
            // 
            this.lblDiaDisponible.AutoSize = true;
            this.lblDiaDisponible.Location = new System.Drawing.Point(371, 209);
            this.lblDiaDisponible.Name = "lblDiaDisponible";
            this.lblDiaDisponible.Size = new System.Drawing.Size(33, 17);
            this.lblDiaDisponible.TabIndex = 16;
            this.lblDiaDisponible.Text = "Dia:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(474, 206);
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
            this.btnCrearProfesional.Location = new System.Drawing.Point(33, 265);
            this.btnCrearProfesional.Name = "btnCrearProfesional";
            this.btnCrearProfesional.Size = new System.Drawing.Size(101, 37);
            this.btnCrearProfesional.TabIndex = 19;
            this.btnCrearProfesional.Text = "Crear";
            this.btnCrearProfesional.UseVisualStyleBackColor = true;
            // 
            // btnIngresarProf
            // 
            this.btnIngresarProf.Location = new System.Drawing.Point(167, 265);
            this.btnIngresarProf.Name = "btnIngresarProf";
            this.btnIngresarProf.Size = new System.Drawing.Size(101, 37);
            this.btnIngresarProf.TabIndex = 20;
            this.btnIngresarProf.Text = "Ingresar";
            this.btnIngresarProf.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProf
            // 
            this.btnActualizarProf.Location = new System.Drawing.Point(319, 266);
            this.btnActualizarProf.Name = "btnActualizarProf";
            this.btnActualizarProf.Size = new System.Drawing.Size(101, 37);
            this.btnActualizarProf.TabIndex = 21;
            this.btnActualizarProf.Text = "Actualizar";
            this.btnActualizarProf.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProf
            // 
            this.btnEliminarProf.Location = new System.Drawing.Point(474, 266);
            this.btnEliminarProf.Name = "btnEliminarProf";
            this.btnEliminarProf.Size = new System.Drawing.Size(101, 37);
            this.btnEliminarProf.TabIndex = 22;
            this.btnEliminarProf.Text = "Eliminar";
            this.btnEliminarProf.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarSubMProf
            // 
            this.btnLimpiarSubMProf.Location = new System.Drawing.Point(603, 265);
            this.btnLimpiarSubMProf.Name = "btnLimpiarSubMProf";
            this.btnLimpiarSubMProf.Size = new System.Drawing.Size(101, 37);
            this.btnLimpiarSubMProf.TabIndex = 23;
            this.btnLimpiarSubMProf.Text = "Limpiar";
            this.btnLimpiarSubMProf.UseVisualStyleBackColor = true;
            // 
            // dgvTelefonoProfesional
            // 
            this.dgvTelefonoProfesional.AllowUserToDeleteRows = false;
            this.dgvTelefonoProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonoProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Numero});
            this.dgvTelefonoProfesional.Location = new System.Drawing.Point(33, 164);
            this.dgvTelefonoProfesional.Name = "dgvTelefonoProfesional";
            this.dgvTelefonoProfesional.Size = new System.Drawing.Size(266, 67);
            this.dgvTelefonoProfesional.TabIndex = 28;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tipo.Width = 90;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // FrmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 614);
            this.Controls.Add(this.dgvTelefonoProfesional);
            this.Controls.Add(this.btnLimpiarSubMProf);
            this.Controls.Add(this.btnEliminarProf);
            this.Controls.Add(this.btnActualizarProf);
            this.Controls.Add(this.btnIngresarProf);
            this.Controls.Add(this.btnCrearProfesional);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lblDiaDisponible);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHoraDelFinal);
            this.Controls.Add(this.lblHoraDeInicio);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.lblApellidoProf);
            this.Controls.Add(this.lblNombreProf);
            this.Controls.Add(this.btnExitMenuProfesional);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProfesional";
            this.Text = "Profesional";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonoProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMenuProfesional;
        private System.Windows.Forms.Label lblNombreProf;
        private System.Windows.Forms.Label lblApellidoProf;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblHoraDeInicio;
        private System.Windows.Forms.Label lblHoraDelFinal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblDiaDisponible;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrearProfesional;
        private System.Windows.Forms.Button btnIngresarProf;
        private System.Windows.Forms.Button btnActualizarProf;
        private System.Windows.Forms.Button btnEliminarProf;
        private System.Windows.Forms.Button btnLimpiarSubMProf;
        private System.Windows.Forms.DataGridView dgvTelefonoProfesional;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}