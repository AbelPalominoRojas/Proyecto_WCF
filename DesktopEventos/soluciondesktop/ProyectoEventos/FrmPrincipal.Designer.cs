namespace ProyectoEventos
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lstaudotiraEUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lstaudotiraAUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.lstaudotiraPUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstaudotiraEUsuario,
            this.lstaudotiraAUsuario,
            this.lstaudotiraPUsuario});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // lstaudotiraEUsuario
            // 
            this.lstaudotiraEUsuario.Name = "lstaudotiraEUsuario";
            this.lstaudotiraEUsuario.Size = new System.Drawing.Size(253, 22);
            this.lstaudotiraEUsuario.Text = "Auditoria de Evento por Usuario";
            this.lstaudotiraEUsuario.Click += new System.EventHandler(this.listadoDeToolStripMenuItem_Click);
            // 
            // lstaudotiraAUsuario
            // 
            this.lstaudotiraAUsuario.Name = "lstaudotiraAUsuario";
            this.lstaudotiraAUsuario.Size = new System.Drawing.Size(253, 22);
            this.lstaudotiraAUsuario.Text = "Auditoria Acciones de Usuario";
            // 
            // lstaudotiraPUsuario
            // 
            this.lstaudotiraPUsuario.Name = "lstaudotiraPUsuario";
            this.lstaudotiraPUsuario.Size = new System.Drawing.Size(253, 22);
            this.lstaudotiraPUsuario.Text = "Auditoria Participante por Usuario";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(149, 22);
            this.toolStripLabel1.Text = "Ruben Palomino | Estandar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 427);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Auditoria de Eventos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem lstaudotiraEUsuario;
        private System.Windows.Forms.ToolStripMenuItem lstaudotiraAUsuario;
        private System.Windows.Forms.ToolStripMenuItem lstaudotiraPUsuario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}