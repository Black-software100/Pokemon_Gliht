using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            Usuario Ousuarrio = new CN_Usuarios().Listar().Where(u => u.Documento == TxtDocumento.Text && u.Clave == TxtClave.Text).FirstOrDefault();

            if(Ousuarrio != null)
            {
                Inicio form = new Inicio(Ousuarrio);
                form.Show();
                this.Hide();
                form.FormClosed += frm_closing;
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_closing(object sender, FormClosedEventArgs e)
        {
            TxtDocumento.Text = "";
            TxtClave.Text = "";
            this.Show();
        }


    }
}
