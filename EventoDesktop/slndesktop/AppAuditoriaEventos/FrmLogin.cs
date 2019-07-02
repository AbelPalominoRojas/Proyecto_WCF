using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAuditoriaEventos
{
    
    public partial class FrmLogin : Form
    {
        UsuarioService.UsuarioServiceClient ous = new UsuarioService.UsuarioServiceClient();
        UsuarioService.Usuario ou = new UsuarioService.Usuario();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ous.login(txtusuario.Text,txtpassword.Text)!=null)
            {
                Form1 of = new Form1();
                of.Show();
            }else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
