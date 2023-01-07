using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.Utlidades;

namespace WindowsFormsApp1
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void TbxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Solonumero(e);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // Combo box estado
            CbxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CbxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CbxEstado.DisplayMember = "Texto";
            CbxEstado.ValueMember = "Valor";
            CbxEstado.SelectedIndex = 0;

            // Combo box Rol
            CbxRol.Items.Add(new OpcionCombo() { Valor = 1 , Texto = "Administrador"});
            CbxRol.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Empleado" });
            CbxRol.DisplayMember = "Texto";
            CbxRol.ValueMember = "Valor";
            CbxRol.SelectedIndex = 0;
        }

        private void TbxCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Solonumero(e);
        }
    }
}
