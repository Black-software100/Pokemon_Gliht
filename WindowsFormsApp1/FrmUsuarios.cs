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

            List<Rol> Lista = new CN_Rol().Listar();

            foreach (Rol iteam in Lista)
            {
                CbxRol.Items.Add(new OpcionCombo() { Valor = iteam.IdRol, Texto = iteam.Descripcion });
            }
            CbxRol.DisplayMember = "Texto";
            CbxRol.ValueMember = "Valor";
            CbxRol.SelectedIndex = 0;

            foreach (DataGridViewColumn column in DvgData.Columns) { 
            
                if(column.Visible == true && column.Name != "btn")
                {
                    CbxBusqueda.Items.Add(new OpcionCombo() { Valor =  column.Name, Texto = column.HeaderText});
                }
                CbxBusqueda.DisplayMember = "Texto";
                CbxBusqueda.ValueMember = "Valor";
               // CbxBusqueda.SelectedIndex = 0;

            }

            List<Usuario> ListaUsuario = new CN_Usuarios().Listar();
            foreach (Usuario item in ListaUsuario)
            {
                DvgData.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, 
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

        }

        

        private void TbxCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Solonumero(e);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DvgData.Rows.Add(new object[] {"", TbxCampo.Text,TbxDocumento.Text,TbxNombre.Text,TbxCorreo.Text,TbxPass.Text,
                ((OpcionCombo)CbxRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CbxRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CbxRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CbxRol.SelectedItem).Texto.ToString()
            });

            Limpiar();
        }

        private void Limpiar()
        {
            TbxCampo.Text = "0";
            TbxDocumento.Text = "";
            TbxNombre.Text = "";
            TbxCorreo.Text = "";
            TbxPass.Text = "";
            TbxPass2.Text = "";
            CbxEstado.SelectedIndex = 0;
            CbxRol.SelectedIndex = 0;
        }


    }
}
