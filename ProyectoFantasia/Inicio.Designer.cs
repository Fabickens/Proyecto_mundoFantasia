namespace ProyectoFantasia
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuprueba = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuarios,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_acercaDe,
            this.menuprueba});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(990, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(990, 72);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "menuStrip2";
            this.titulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Refugio del Aventurero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuprueba
            // 
            this.menuprueba.AutoSize = false;
            this.menuprueba.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menuprueba.IconColor = System.Drawing.Color.Black;
            this.menuprueba.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprueba.IconSize = 50;
            this.menuprueba.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprueba.Name = "menuprueba";
            this.menuprueba.Size = new System.Drawing.Size(80, 69);
            this.menuprueba.Text = "Usuarios";
            this.menuprueba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_acercaDe
            // 
            this.menu_acercaDe.AutoSize = false;
            this.menu_acercaDe.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_acercaDe.IconColor = System.Drawing.Color.Black;
            this.menu_acercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acercaDe.IconSize = 50;
            this.menu_acercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercaDe.Name = "menu_acercaDe";
            this.menu_acercaDe.Size = new System.Drawing.Size(80, 69);
            this.menu_acercaDe.Text = "Acerca de";
            this.menu_acercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.IconSize = 50;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(80, 69);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedores.IconSize = 50;
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(80, 69);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 50;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(80, 69);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.IconSize = 50;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(80, 69);
            this.menu_compras.Text = "Compras";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.IconSize = 50;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(80, 69);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_usuarios
            // 
            this.menu_usuarios.AutoSize = false;
            this.menu_usuarios.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.menu_usuarios.IconColor = System.Drawing.Color.Black;
            this.menu_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuarios.IconSize = 50;
            this.menu_usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuarios.Name = "menu_usuarios";
            this.menu_usuarios.Size = new System.Drawing.Size(80, 69);
            this.menu_usuarios.Text = "Usuarios";
            this.menu_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 439);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip titulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuprueba;
        private FontAwesome.Sharp.IconMenuItem menu_usuarios;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
        private FontAwesome.Sharp.IconMenuItem menu_acercaDe;
        private System.Windows.Forms.Panel panel1;
    }
}

