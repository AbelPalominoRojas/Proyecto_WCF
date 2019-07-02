namespace ProyectoEventos
{
    partial class FrmAuditarUsuarios
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
            this.gvauditarusuario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvauditarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gvauditarusuario
            // 
            this.gvauditarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvauditarusuario.Location = new System.Drawing.Point(12, 24);
            this.gvauditarusuario.Name = "gvauditarusuario";
            this.gvauditarusuario.Size = new System.Drawing.Size(544, 279);
            this.gvauditarusuario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAuditarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvauditarusuario);
            this.Name = "FrmAuditarUsuarios";
            this.Text = "Auditoria de Usuario";
            this.Load += new System.EventHandler(this.FrmAuditarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvauditarusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvauditarusuario;
        private System.Windows.Forms.Button button1;
    }
}