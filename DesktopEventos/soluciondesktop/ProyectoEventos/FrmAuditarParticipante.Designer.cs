namespace ProyectoEventos
{
    partial class FrmAuditarParticipante
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
            this.button1 = new System.Windows.Forms.Button();
            this.gvauditarusuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvauditarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gvauditarusuario
            // 
            this.gvauditarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvauditarusuario.Location = new System.Drawing.Point(12, 21);
            this.gvauditarusuario.Name = "gvauditarusuario";
            this.gvauditarusuario.Size = new System.Drawing.Size(544, 279);
            this.gvauditarusuario.TabIndex = 2;
            // 
            // FrmAuditarParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvauditarusuario);
            this.Name = "FrmAuditarParticipante";
            this.Text = "Auditoria de Usuario a Participante";
            ((System.ComponentModel.ISupportInitialize)(this.gvauditarusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvauditarusuario;
    }
}