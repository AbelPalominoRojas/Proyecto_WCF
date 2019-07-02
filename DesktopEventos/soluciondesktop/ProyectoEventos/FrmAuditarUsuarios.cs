using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoEventos
{
    public partial class FrmAuditarUsuarios : Form
    {
        

        public FrmAuditarUsuarios()
        {
            
           InitializeComponent();
        }

        
        private void FrmAuditarUsuarios_Load(object sender, EventArgs e)
        {
            SRefUsuario.UsuarioServiceClient ouws = new SRefUsuario.UsuarioServiceClient();
            gvauditarusuario.DataSource = ouws.listar().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
