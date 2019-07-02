using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEventos
{
    public partial class Form1 : Form
    {
        SRefUsuario.UsuarioServiceClient sruws = new SRefUsuario.UsuarioServiceClient();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnacceso_Click(object sender, EventArgs e)
        {

            if (sruws.login(txtusuario.Text,txtpassword.Text)!=null)
            {
                MessageBox.Show("OK");
                FrmPrincipal ofprincipal = new FrmPrincipal();
                ofprincipal.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
