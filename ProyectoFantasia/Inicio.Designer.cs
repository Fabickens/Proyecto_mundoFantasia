using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_acercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Almacenamiento = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_empleados,
            this.menu_ventas,
            this.menu_productos,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_acercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1211, 86);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_empleados
            // 
            this.menu_empleados.AutoSize = false;
            this.menu_empleados.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_empleados.ForeColor = System.Drawing.Color.Black;
            this.menu_empleados.Image = ((System.Drawing.Image)(resources.GetObject("menu_empleados.Image")));
            this.menu_empleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_empleados.Name = "menu_empleados";
            this.menu_empleados.Size = new System.Drawing.Size(122, 82);
            this.menu_empleados.Text = "Empleados";
            this.menu_empleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_empleados.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ventas.ForeColor = System.Drawing.Color.Black;
            this.menu_ventas.Image = ((System.Drawing.Image)(resources.GetObject("menu_ventas.Image")));
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(80, 82);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_productos
            // 
            this.menu_productos.AutoSize = false;
            this.menu_productos.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_productos.ForeColor = System.Drawing.Color.Black;
            this.menu_productos.Image = ((System.Drawing.Image)(resources.GetObject("menu_productos.Image")));
            this.menu_productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_productos.Name = "menu_productos";
            this.menu_productos.Size = new System.Drawing.Size(80, 82);
            this.menu_productos.Text = "Productos";
            this.menu_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_productos.Click += new System.EventHandler(this.menu_compras_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_clientes.ForeColor = System.Drawing.Color.Black;
            this.menu_clientes.Image = ((System.Drawing.Image)(resources.GetObject("menu_clientes.Image")));
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(80, 82);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.menu_clientes_Click);
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_proveedores.ForeColor = System.Drawing.Color.Black;
            this.menu_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("menu_proveedores.Image")));
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(80, 82);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_reportes.ForeColor = System.Drawing.Color.Black;
            this.menu_reportes.Image = ((System.Drawing.Image)(resources.GetObject("menu_reportes.Image")));
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(80, 82);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_acercaDe
            // 
            this.menu_acercaDe.AutoSize = false;
            this.menu_acercaDe.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_acercaDe.ForeColor = System.Drawing.Color.Black;
            this.menu_acercaDe.Image = ((System.Drawing.Image)(resources.GetObject("menu_acercaDe.Image")));
            this.menu_acercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercaDe.Name = "menu_acercaDe";
            this.menu_acercaDe.Size = new System.Drawing.Size(80, 82);
            this.menu_acercaDe.Text = "Acerca de";
            this.menu_acercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // titulo
            // 
            this.titulo.AutoSize = false;
            this.titulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(1211, 72);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Almacenamiento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 579);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Almacenamiento
            // 
            this.Almacenamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Almacenamiento.Location = new System.Drawing.Point(0, 0);
            this.Almacenamiento.Name = "Almacenamiento";
            this.Almacenamiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Almacenamiento.Size = new System.Drawing.Size(1211, 579);
            this.Almacenamiento.TabIndex = 0;
            this.Almacenamiento.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 737);
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menu_empleados;
        private System.Windows.Forms.ToolStripMenuItem menu_ventas;
        private System.Windows.Forms.ToolStripMenuItem menu_productos;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_proveedores;
        private System.Windows.Forms.ToolStripMenuItem menu_reportes;
        private System.Windows.Forms.ToolStripMenuItem menu_acercaDe;
        private System.Windows.Forms.Panel Almacenamiento;
    }
}

