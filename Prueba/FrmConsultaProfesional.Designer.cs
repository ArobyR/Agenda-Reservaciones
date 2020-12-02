
namespace AgendaCita
{
    partial class FrmConsultaProfesional
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
            this.lblProfesionales = new System.Windows.Forms.Label();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.dgvProfesional = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesionales
            // 
            this.lblProfesionales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfesionales.AutoSize = true;
            this.lblProfesionales.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesionales.Location = new System.Drawing.Point(277, 9);
            this.lblProfesionales.Name = "lblProfesionales";
            this.lblProfesionales.Size = new System.Drawing.Size(159, 32);
            this.lblProfesionales.TabIndex = 0;
            this.lblProfesionales.Text = "Profesionales";
            // 
            // txtProfesional
            // 
            this.txtProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfesional.Location = new System.Drawing.Point(12, 74);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(684, 27);
            this.txtProfesional.TabIndex = 1;
            this.txtProfesional.TextChanged += new System.EventHandler(this.txtProfesional_TextChanged);
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.AllowUserToAddRows = false;
            this.dgvProfesional.AllowUserToDeleteRows = false;
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProfesional.Location = new System.Drawing.Point(0, 124);
            this.dgvProfesional.Name = "dgvProfesional";
            this.dgvProfesional.ReadOnly = true;
            this.dgvProfesional.Size = new System.Drawing.Size(708, 287);
            this.dgvProfesional.TabIndex = 2;
            this.dgvProfesional.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesional_CellDoubleClick);
            // 
            // FrmConsultaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 411);
            this.Controls.Add(this.dgvProfesional);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.lblProfesionales);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmConsultaProfesional";
            this.Text = "Consulta Profesional";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesionales;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.DataGridView dgvProfesional;
    }
}