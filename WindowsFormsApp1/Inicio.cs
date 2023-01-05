using CapaEntidad;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private static Form FormularioActivo = null;
        private static IconMenuItem MenuActivo = null;
        private static Usuario usuarioActual;

      public Inicio(Usuario ObjUsuario = null)
        {
            if (ObjUsuario == null) usuarioActual = new Usuario() { NombreCompleto = "Admin PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual= ObjUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach (IconMenuItem iconMenu in Menu.Items)
            {
                bool Encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                //if(Encontrado == false)
                //{
                 //   iconMenu.Visible= false;
               // }
            }
           
            LblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form Formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.Violet;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void MnuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void Submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCategoria());
        }

        private void Subcategoriaproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProducto());
        }

        private void SubMenuRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmVentas());
        }

        private void SubMenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmDetalleVenta());
        }

        private void SubmenuRegistra_Click(object sender, EventArgs e)
        {

        }

        private void SubmenuVerFetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmDetalleCompra());
        }

        private void MnuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void MnuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }

        private void MnuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmReportes());
        }
    }
}
