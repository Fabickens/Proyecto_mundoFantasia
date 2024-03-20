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
        private string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            string query = "SELECT id_producto, codigo, nombre, p.descripcion AS descripcion_producto, c.id_categoria, c.descripcion AS descripcion_categoria, disponibles, precioCompra, precioVenta FROM productos p INNER JOIN categoria c ON c.id_categoria = p.id_categoria";

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
            dataGridViewEmpleados.Columns["descripcion_producto"].HeaderText = "Descripcion";
            dataGridViewEmpleados.Columns["id_categoria"].Visible = false;
            dataGridViewEmpleados.Columns["descripcion_categoria"].HeaderText = "Descripcion Categoria";
            dataGridViewEmpleados.Columns["disponibles"].HeaderText = "Disponibles";
            dataGridViewEmpleados.Columns["precioCompra"].HeaderText = "Precio Compra";
            dataGridViewEmpleados.Columns["precioVenta"].HeaderText = "Precio Venta";
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "seleccionarbtn")
            {
                int indice = e.RowIndex;
                textBox1.Text = dataGridViewEmpleados.Rows[indice].Cells["id_producto"].Value.ToString();
                text_codigo.Text = dataGridViewEmpleados.Rows[indice].Cells["codigo"].Value.ToString();
                txt_nombreProducto.Text = dataGridViewEmpleados.Rows[indice].Cells["nombre"].Value.ToString();
                text_descripcion.Text = dataGridViewEmpleados.Rows[indice].Cells["descripcion_producto"].Value.ToString();
                text_categoria.Text = dataGridViewEmpleados.Rows[indice].Cells["descripcion_categoria"].Value.ToString();
                text_disponibles.Text = dataGridViewEmpleados.Rows[indice].Cells["disponibles"].Value.ToString();
                text_precioCompra.Text = dataGridViewEmpleados.Rows[indice].Cells["precioCompra"].Value.ToString();
                text_precioVenta.Text = dataGridViewEmpleados.Rows[indice].Cells["precioVenta"].Value.ToString();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM productos WHERE id_producto = @Idproducto";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Idproducto", textBox1.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto eliminado correctamente.");
                    ActualizarDataGridView();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO productos (codigo, nombre, descripcion, disponibles, precioCompra, precioVenta) VALUES (@codigo, @nombre, @descripcion, @disponibles, @precioCompra, @precioVenta)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigo", text_codigo.Text);
                    command.Parameters.AddWithValue("@nombre", txt_nombreProducto.Text);
                    command.Parameters.AddWithValue("@descripcion", text_descripcion.Text);
                    command.Parameters.AddWithValue("@disponibles", text_disponibles.Text);
                    command.Parameters.AddWithValue("@precioCompra", text_precioCompra.Text);
                    command.Parameters.AddWithValue("@precioVenta", text_precioVenta.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Producto guardado correctamente.");
                ActualizarDataGridView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }
    }
}
