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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auditoria_Paticipante_por_UsuarioService.Auditoria_Paticipante_por_UsuarioServiceClient oaps = new Auditoria_Paticipante_por_UsuarioService.Auditoria_Paticipante_por_UsuarioServiceClient();
        Auditoria_Paticipante_por_UsuarioService.Auditoria_Paticipante_por_Usuario  oa = new Auditoria_Paticipante_por_UsuarioService.Auditoria_Paticipante_por_Usuario();
        private void button1_Click(object sender, EventArgs e)
        {
            oa.Email_usuario = textBox1.Text;
            oa.CodParticipante =Convert.ToInt32(textBox2.Text);
            oa.Fecha =Convert.ToDateTime(textBox3.Text);
            oa.Accion = textBox4.Text;
            if (oaps.registrar(oa) != null)
            {
                MessageBox.Show("Registrado Correctamente");
            }else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
