namespace WindowsFormsApp1
{
    partial class Inicio
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
            this.MenuNombre = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MnuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MnuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.Submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.Subcategoriaproducto = new FontAwesome.Sharp.IconMenuItem();
            this.MnuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalle = new FontAwesome.Sharp.IconMenuItem();
            this.MnuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistra = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuVerFetalle = new FontAwesome.Sharp.IconMenuItem();
            this.MnuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MnuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MnuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MnuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuNombre
            // 
            this.MenuNombre.AutoSize = false;
            this.MenuNombre.BackColor = System.Drawing.Color.DarkCyan;
            this.MenuNombre.Location = new System.Drawing.Point(0, 0);
            this.MenuNombre.Name = "MenuNombre";
            this.MenuNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuNombre.Size = new System.Drawing.Size(1046, 74);
            this.MenuNombre.TabIndex = 2;
            this.MenuNombre.Text = "menuStrip2";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUsuarios,
            this.MnuMantenedor,
            this.MnuVentas,
            this.MnuCompras,
            this.MnuClientes,
            this.MnuProveedores,
            this.MnuReportes,
            this.MnuAcercaDe});
            this.Menu.Location = new System.Drawing.Point(0, 74);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1046, 73);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // MnuUsuarios
            // 
            this.MnuUsuarios.BackColor = System.Drawing.Color.White;
            this.MnuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MnuUsuarios.IconColor = System.Drawing.Color.Black;
            this.MnuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuUsuarios.IconSize = 50;
            this.MnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuUsuarios.Name = "MnuUsuarios";
            this.MnuUsuarios.Size = new System.Drawing.Size(64, 69);
            this.MnuUsuarios.Text = "Usuarios";
            this.MnuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnuUsuarios.Click += new System.EventHandler(this.MnuUsuarios_Click);
            // 
            // MnuMantenedor
            // 
            this.MnuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenucategoria,
            this.Subcategoriaproducto});
            this.MnuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MnuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MnuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuMantenedor.IconSize = 50;
            this.MnuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuMantenedor.Name = "MnuMantenedor";
            this.MnuMantenedor.Size = new System.Drawing.Size(84, 69);
            this.MnuMantenedor.Text = "Mantenedor";
            this.MnuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Submenucategoria
            // 
            this.Submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Submenucategoria.IconColor = System.Drawing.Color.Black;
            this.Submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Submenucategoria.Name = "Submenucategoria";
            this.Submenucategoria.Size = new System.Drawing.Size(125, 22);
            this.Submenucategoria.Text = "Categoria";
            this.Submenucategoria.Click += new System.EventHandler(this.Submenucategoria_Click);
            // 
            // Subcategoriaproducto
            // 
            this.Subcategoriaproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Subcategoriaproducto.IconColor = System.Drawing.Color.Black;
            this.Subcategoriaproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Subcategoriaproducto.Name = "Subcategoriaproducto";
            this.Subcategoriaproducto.Size = new System.Drawing.Size(125, 22);
            this.Subcategoriaproducto.Text = "Producto";
            this.Subcategoriaproducto.Click += new System.EventHandler(this.Subcategoriaproducto_Click);
            // 
            // MnuVentas
            // 
            this.MnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrar,
            this.SubMenuVerDetalle});
            this.MnuVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.MnuVentas.IconColor = System.Drawing.Color.Black;
            this.MnuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuVentas.IconSize = 50;
            this.MnuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuVentas.Name = "MnuVentas";
            this.MnuVentas.Size = new System.Drawing.Size(62, 69);
            this.MnuVentas.Text = "Ventas";
            this.MnuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrar
            // 
            this.SubMenuRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrar.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrar.Name = "SubMenuRegistrar";
            this.SubMenuRegistrar.Size = new System.Drawing.Size(129, 22);
            this.SubMenuRegistrar.Text = "Registrar";
            this.SubMenuRegistrar.Click += new System.EventHandler(this.SubMenuRegistrar_Click);
            // 
            // SubMenuVerDetalle
            // 
            this.SubMenuVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalle.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalle.Name = "SubMenuVerDetalle";
            this.SubMenuVerDetalle.Size = new System.Drawing.Size(129, 22);
            this.SubMenuVerDetalle.Text = "Ver Detalle";
            this.SubMenuVerDetalle.Click += new System.EventHandler(this.SubMenuVerDetalle_Click);
            // 
            // MnuCompras
            // 
            this.MnuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistra,
            this.SubmenuVerFetalle});
            this.MnuCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.MnuCompras.IconColor = System.Drawing.Color.Black;
            this.MnuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuCompras.IconSize = 50;
            this.MnuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuCompras.Name = "MnuCompras";
            this.MnuCompras.Size = new System.Drawing.Size(67, 69);
            this.MnuCompras.Text = "Compras";
            this.MnuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistra
            // 
            this.SubmenuRegistra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRegistra.IconColor = System.Drawing.Color.Black;
            this.SubmenuRegistra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistra.Name = "SubmenuRegistra";
            this.SubmenuRegistra.Size = new System.Drawing.Size(180, 22);
            this.SubmenuRegistra.Text = "Registrar";
            this.SubmenuRegistra.Click += new System.EventHandler(this.SubmenuRegistra_Click);
            // 
            // SubmenuVerFetalle
            // 
            this.SubmenuVerFetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuVerFetalle.IconColor = System.Drawing.Color.Black;
            this.SubmenuVerFetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuVerFetalle.Name = "SubmenuVerFetalle";
            this.SubmenuVerFetalle.Size = new System.Drawing.Size(180, 22);
            this.SubmenuVerFetalle.Text = "Ver Detalle";
            this.SubmenuVerFetalle.Click += new System.EventHandler(this.SubmenuVerFetalle_Click);
            // 
            // MnuClientes
            // 
            this.MnuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.MnuClientes.IconColor = System.Drawing.Color.Black;
            this.MnuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuClientes.IconSize = 50;
            this.MnuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuClientes.Name = "MnuClientes";
            this.MnuClientes.Size = new System.Drawing.Size(62, 69);
            this.MnuClientes.Text = "Cliente";
            this.MnuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnuClientes.Click += new System.EventHandler(this.MnuClientes_Click);
            // 
            // MnuProveedores
            // 
            this.MnuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MnuProveedores.IconColor = System.Drawing.Color.Black;
            this.MnuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuProveedores.IconSize = 50;
            this.MnuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuProveedores.Name = "MnuProveedores";
            this.MnuProveedores.Size = new System.Drawing.Size(84, 69);
            this.MnuProveedores.Text = "Proveedores";
            this.MnuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnuProveedores.Click += new System.EventHandler(this.MnuProveedores_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.MnuReportes.IconColor = System.Drawing.Color.Black;
            this.MnuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuReportes.IconSize = 50;
            this.MnuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(65, 69);
            this.MnuReportes.Text = "Reportes";
            this.MnuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnuReportes.Click += new System.EventHandler(this.MnuReportes_Click);
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MnuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MnuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MnuAcercaDe.IconSize = 50;
            this.MnuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(71, 69);
            this.MnuAcercaDe.Text = "Acerca de";
            this.MnuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistemas de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(708, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(771, 36);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 16);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "LblUsuario";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 147);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1046, 428);
            this.Contenedor.TabIndex = 7;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 575);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuNombre);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuNombre;
        private System.Windows.Forms.MenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem MnuUsuarios;
        private FontAwesome.Sharp.IconMenuItem MnuMantenedor;
        private FontAwesome.Sharp.IconMenuItem Submenucategoria;
        private FontAwesome.Sharp.IconMenuItem Subcategoriaproducto;
        private FontAwesome.Sharp.IconMenuItem MnuVentas;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrar;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalle;
        private FontAwesome.Sharp.IconMenuItem MnuCompras;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistra;
        private FontAwesome.Sharp.IconMenuItem SubmenuVerFetalle;
        private FontAwesome.Sharp.IconMenuItem MnuClientes;
        private FontAwesome.Sharp.IconMenuItem MnuProveedores;
        private FontAwesome.Sharp.IconMenuItem MnuReportes;
        private FontAwesome.Sharp.IconMenuItem MnuAcercaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Panel Contenedor;
    }
}