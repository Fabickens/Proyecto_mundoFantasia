using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFantasia
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "SELECT * From productos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmpleados.DataSource = table;
            }

            dataGridViewEmpleados.Columns["id_producto"].Visible = false;
            dataGridViewEmpleados.Columns["codigo"].HeaderText = "Codigo";
            dataGridViewEmpleados.Columns["nombre"].HeaderText = "Nombre Producto";
            dataGridViewEmpleados.Columns["descripcion"].HeaderText = "Descripcion";
            dataGridViewEmpleados.Columns["id_categoria"].Visible = false;
            dataGridViewEmpleados.Columns["disponibles"].HeaderText = "Disponibles";
            dataGridViewEmpleados.Columns["precioCompra"].HeaderText = "Precio Compra";
            dataGridViewEmpleados.Columns["precioVenta"].HeaderText = "Precio Venta";
            dataGridViewEmpleados.Columns["fecha_registro"].HeaderText = "Fecha Registro";

        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "seleccionarbtn")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox1.Text = dataGridViewEmpleados.Rows[indice].Cells["id_producto"].Value.ToString();
                    text_codigo.Text = dataGridViewEmpleados.Rows[indice].Cells["codigo"].Value.ToString();
                    txt_nombreProducto.Text = dataGridViewEmpleados.Rows[indice].Cells["nombre"].Value.ToString();
                    text_descripcion.Text = dataGridViewEmpleados.Rows[indice].Cells["descripcion"].Value.ToString();
                    text_disponibles.Text = dataGridViewEmpleados.Rows[indice].Cells["disponibles"].Value.ToString();
                    text_precioCompra.Text = dataGridViewEmpleados.Rows[indice].Cells["precioCompra"].Value.ToString();
                    text_precioVenta.Text = dataGridViewEmpleados.Rows[indice].Cells["precioVenta"].Value.ToString();


                }
            }
        }
    }
}
