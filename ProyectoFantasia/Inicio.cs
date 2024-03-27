using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFantasia
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            LimpiarAlmacenamiento();
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.TopLevel = false;
            formEmpleados.FormBorderStyle = FormBorderStyle.None;
            formEmpleados.Dock = DockStyle.Fill;
            formEmpleados.BackColor = Color.LightGray;
            Almacenamiento.Controls.Add(formEmpleados);
            formEmpleados.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {        

        }
        
        private void LimpiarAlmacenamiento()
        {
            foreach (Control control in Almacenamiento.Controls)
            {
                control.Dispose();
            }
            Almacenamiento.Controls.Clear();
        }

        private void MenuCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void menu_clientes_Click(object sender, EventArgs e)
        {
            LimpiarAlmacenamiento();
            FormClientes formClientes = new FormClientes();
            formClientes.TopLevel = false;
            formClientes.FormBorderStyle = FormBorderStyle.None;
            formClientes.Dock = DockStyle.Fill;
            formClientes.BackColor = Color.LightGray;
            Almacenamiento.Controls.Add(formClientes);
            formClientes.Show();
        }

        private void menu_compras_Click(object sender, EventArgs e)
        {
            LimpiarAlmacenamiento();
            FormProductos formProdutos = new FormProductos();
            formProdutos.TopLevel = false;
            formProdutos.FormBorderStyle = FormBorderStyle.None;
            formProdutos.Dock = DockStyle.Fill;
            formProdutos.BackColor = Color.LightGray;
            Almacenamiento.Controls.Add(formProdutos);
            formProdutos.Show();
        }
    }
}
