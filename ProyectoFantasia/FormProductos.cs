using Entidad;
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
        private const string ConnectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=TiendaFantasia; integrated security=true";
        public FormProductos()
        {
            InitializeComponent();
        }
      

        private void FormProductos_Load(object sender, EventArgs e)
        {
           MostrarProductos();
        }
        private void MostrarProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM producto";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            IdProducto = Convert.ToInt32(reader["id_producto"]),
                            Nombre = reader["nombre"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Categoria = reader["categoria"].ToString(),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Proveedor = reader["proveedor"].ToString()
                        };
                        productos.Add(producto);
                    }
                    reader.Close();
                }
                dataGridViewProductos.AutoGenerateColumns = false;
                dataGridViewProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];
                textBox1.Text = row.Cells["IdProducto"].Value.ToString();
                txt_nombreProducto.Text = row.Cells["Nombre"].Value.ToString();
                text_descripcion.Text = row.Cells["Descripcion"].Value.ToString();
                text_precio.Text = row.Cells["Precio"].Value.ToString();
                comboBox1.Text = row.Cells["Categoria"].Value.ToString();
                text_disponibles.Text = row.Cells["Stock"].Value.ToString();
                textBox2.Text = row.Cells["Proveedor"].Value.ToString();
                text_indice.Text = e.RowIndex.ToString();
            }
        }
        private void LimpiarCampos()
        {
            textBox1.Text = "";
            txt_nombreProducto.Text = "";
            textBox2.Text = "";
            text_descripcion.Text = "";
            text_disponibles.Text = "";
            text_indice.Text = "";
            text_precio.Text = "";
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto
            {
                Nombre = txt_nombreProducto.Text,
                Descripcion = text_descripcion.Text,
                Precio = decimal.Parse(text_precio.Text),
                Categoria = comboBox1.Text,
                Stock = int.Parse(text_disponibles.Text),
                Proveedor = textBox2.Text
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO producto (nombre, descripcion, precio, categoria, stock, proveedor) " +
                                   "VALUES (@nombre, @descripcion, @precio, @categoria, @stock, @proveedor)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nuevoProducto.Nombre);
                    command.Parameters.AddWithValue("@descripcion", nuevoProducto.Descripcion);
                    command.Parameters.AddWithValue("@precio", nuevoProducto.Precio);
                    command.Parameters.AddWithValue("@categoria", nuevoProducto.Categoria);
                    command.Parameters.AddWithValue("@stock", nuevoProducto.Stock);
                    command.Parameters.AddWithValue("@proveedor", nuevoProducto.Proveedor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Producto guardado correctamente.");
                MostrarProductos(); // Actualizar la vista de los productos
                LimpiarCampos(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != 0)
            {

                int idProducto = Convert.ToInt32(textBox1.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Eliminar el empleado
                        string query = "DELETE FROM producto WHERE id_producto = @idProducto";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idProducto", idProducto);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto eliminado correctamente.");
                    MostrarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != 0)
            {
                

                Producto productoModificado = new Producto
                {
                    IdProducto = Convert.ToInt32(textBox1.Text),
                    Nombre = txt_nombreProducto.Text,
                    Descripcion = text_descripcion.Text,
                    Precio = decimal.Parse(text_precio.Text),
                    Categoria = comboBox1.Text,
                    Stock = int.Parse(text_disponibles.Text),
                    Proveedor = textBox2.Text
                };

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        string query = "UPDATE producto SET nombre = @nombre, descripcion = @descripcion, " +
                                       "precio = @precio, categoria = @categoria, stock = @stock, proveedor = @proveedor " +
                                       "WHERE id_producto = @idProducto";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombre", productoModificado.Nombre);
                        command.Parameters.AddWithValue("@descripcion", productoModificado.Descripcion);
                        command.Parameters.AddWithValue("@precio", productoModificado.Precio);
                        command.Parameters.AddWithValue("@categoria", productoModificado.Categoria);
                        command.Parameters.AddWithValue("@stock", productoModificado.Stock);
                        command.Parameters.AddWithValue("@proveedor", productoModificado.Proveedor);
                        command.Parameters.AddWithValue("@idProducto", productoModificado.IdProducto);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto actualizado correctamente.");
                    MostrarProductos(); // Actualizar la vista de los productos
                    LimpiarCampos(); // Limpiar los campos de entrada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
            }
        }
    }
}
