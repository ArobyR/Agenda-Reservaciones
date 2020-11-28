namespace AgendaCita
{
    partial class Formulario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.panelSideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelLogo1 = new System.Windows.Forms.Panel();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.BtnSubMenuCitas = new System.Windows.Forms.Button();
            this.btnSubProfesionales = new System.Windows.Forms.Button();
            this.btnSubUsuarios = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnExitAplication = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.PanelLogo1);
            this.panelSideMenu.Controls.Add(this.btnMenu1);
            this.panelSideMenu.Controls.Add(this.panelSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAyuda);
            this.panelSideMenu.Controls.Add(this.btnExitAplication);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 611);
            this.panelSideMenu.TabIndex = 5;
            // 
            // PanelLogo1
            // 
            this.PanelLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo1.BackgroundImage")));
            this.PanelLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelLogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PanelLogo1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PanelLogo1.Location = new System.Drawing.Point(3, 3);
            this.PanelLogo1.Name = "PanelLogo1";
            this.PanelLogo1.Padding = new System.Windows.Forms.Padding(40);
            this.PanelLogo1.Size = new System.Drawing.Size(250, 117);
            this.PanelLogo1.TabIndex = 1;
            // 
            // btnMenu1
            // 
            this.btnMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu1.FlatAppearance.BorderSize = 0;
            this.btnMenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(219)))));
            this.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.ForeColor = System.Drawing.Color.White;
            this.btnMenu1.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu1.Image")));
            this.btnMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu1.Location = new System.Drawing.Point(1, 124);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(1);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenu1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu1.Size = new System.Drawing.Size(250, 45);
            this.btnMenu1.TabIndex = 2;
            this.btnMenu1.Text = "Menu";
            this.btnMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu.Controls.Add(this.BtnSubMenuCitas);
            this.panelSubMenu.Controls.Add(this.btnSubProfesionales);
            this.panelSubMenu.Controls.Add(this.btnSubUsuarios);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(3, 173);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(250, 142);
            this.panelSubMenu.TabIndex = 3;
            // 
            // BtnSubMenuCitas
            // 
            this.BtnSubMenuCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubMenuCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubMenuCitas.FlatAppearance.BorderSize = 0;
            this.BtnSubMenuCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.BtnSubMenuCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(219)))));
            this.BtnSubMenuCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubMenuCitas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubMenuCitas.ForeColor = System.Drawing.Color.White;
            this.BtnSubMenuCitas.Image = ((System.Drawing.Image)(resources.GetObject("BtnSubMenuCitas.Image")));
            this.BtnSubMenuCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubMenuCitas.Location = new System.Drawing.Point(0, 90);
            this.BtnSubMenuCitas.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSubMenuCitas.Name = "BtnSubMenuCitas";
            this.BtnSubMenuCitas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnSubMenuCitas.Size = new System.Drawing.Size(250, 51);
            this.BtnSubMenuCitas.TabIndex = 2;
            this.BtnSubMenuCitas.Text = "Citas";
            this.BtnSubMenuCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubMenuCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubMenuCitas.UseVisualStyleBackColor = true;
            this.BtnSubMenuCitas.Click += new System.EventHandler(this.BtnSubMenuCitas_Click);
            // 
            // btnSubProfesionales
            // 
            this.btnSubProfesionales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubProfesionales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProfesionales.FlatAppearance.BorderSize = 0;
            this.btnSubProfesionales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.btnSubProfesionales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(219)))));
            this.btnSubProfesionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProfesionales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubProfesionales.ForeColor = System.Drawing.Color.White;
            this.btnSubProfesionales.Image = ((System.Drawing.Image)(resources.GetObject("btnSubProfesionales.Image")));
            this.btnSubProfesionales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProfesionales.Location = new System.Drawing.Point(0, 45);
            this.btnSubProfesionales.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubProfesionales.Name = "btnSubProfesionales";
            this.btnSubProfesionales.Padding = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.btnSubProfesionales.Size = new System.Drawing.Size(250, 45);
            this.btnSubProfesionales.TabIndex = 1;
            this.btnSubProfesionales.Text = "Profesionales";
            this.btnSubProfesionales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProfesionales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubProfesionales.UseVisualStyleBackColor = true;
            this.btnSubProfesionales.Click += new System.EventHandler(this.btnSubProfesionales_Click);
            // 
            // btnSubUsuarios
            // 
            this.btnSubUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUsuarios.FlatAppearance.BorderSize = 0;
            this.btnSubUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.btnSubUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnSubUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnSubUsuarios.Image")));
            this.btnSubUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnSubUsuarios.Name = "btnSubUsuarios";
            this.btnSubUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubUsuarios.Size = new System.Drawing.Size(250, 45);
            this.btnSubUsuarios.TabIndex = 0;
            this.btnSubUsuarios.Text = "Usuarios";
            this.btnSubUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubUsuarios.UseVisualStyleBackColor = true;
            this.btnSubUsuarios.Click += new System.EventHandler(this.btnSubUsuarios_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(219)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(1, 319);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(1);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(250, 45);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnExitAplication
            // 
            this.btnExitAplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExitAplication.FlatAppearance.BorderSize = 0;
            this.btnExitAplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(163)))), ((int)(((byte)(219)))));
            this.btnExitAplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAplication.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitAplication.ForeColor = System.Drawing.Color.White;
            this.btnExitAplication.Image = ((System.Drawing.Image)(resources.GetObject("btnExitAplication.Image")));
            this.btnExitAplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitAplication.Location = new System.Drawing.Point(1, 366);
            this.btnExitAplication.Margin = new System.Windows.Forms.Padding(1);
            this.btnExitAplication.Name = "btnExitAplication";
            this.btnExitAplication.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExitAplication.Size = new System.Drawing.Size(250, 45);
            this.btnExitAplication.TabIndex = 4;
            this.btnExitAplication.Text = "Salir";
            this.btnExitAplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitAplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitAplication.UseVisualStyleBackColor = true;
            this.btnExitAplication.Click += new System.EventHandler(this.btnExitAplication_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(724, 611);
            this.panelChildForm.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 292);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 611);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Formulario";
            this.Text = "Agenda De Citas";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelSideMenu;
        private System.Windows.Forms.Panel PanelLogo1;
        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button BtnSubMenuCitas;
        private System.Windows.Forms.Button btnSubProfesionales;
        private System.Windows.Forms.Button btnSubUsuarios;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnExitAplication;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

