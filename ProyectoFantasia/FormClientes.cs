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
    public partial class FormClientes : Form
    {
        private const string ConnectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=TiendaFantasia; integrated security=true";
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM cliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(reader["id_cliente"]),
                            NombreCliente = reader["nombre_completo"].ToString(),
                            Cedula = reader["cedula"].ToString(),
                            Direccion = reader["direccion"].ToString(),
                            Correo = reader["correo"].ToString(),
                        };
                        clientes.Add(cliente);
                    }
                    reader.Close();
                }
                dataGridViewClientes.AutoGenerateColumns = false;
                dataGridViewClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];
                textBox1.Text = row.Cells["IdCliente"].Value.ToString();
                txt_nombreCompleto.Text = row.Cells["NombreCliente"].Value.ToString();
                text_cedula.Text = row.Cells["Cedula"].Value.ToString();
                text_direccion.Text = row.Cells["Direccion"].Value.ToString();
                text_correo.Text = row.Cells["Correo"].Value.ToString();
                text_indice.Text = e.RowIndex.ToString();
            }
        }
        private void LimpiarCampos()
        {
            textBox1.Text = "";
            txt_nombreCompleto.Text = "";
            text_cedula.Text = "";
            text_direccion.Text = "";
            text_indice.Text = "";
            text_correo.Text = "";
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                NombreCliente = txt_nombreCompleto.Text,
                Cedula = text_cedula.Text,
                Direccion = text_direccion.Text,
                Correo = text_correo.Text,             
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "INSERT INTO cliente (nombre_completo, cedula, direccion, correo) " +
                                   "VALUES (@nombre_completo, @cedula, @direccion, @correo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre_completo", nuevoCliente.NombreCliente);
                    command.Parameters.AddWithValue("@cedula", nuevoCliente.Cedula);
                    command.Parameters.AddWithValue("@direccion", nuevoCliente.Direccion);
                    command.Parameters.AddWithValue("@correo", nuevoCliente.Correo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente guardado correctamente.");
                MostrarClientes(); // Actualizar la vista de los productos
                LimpiarCampos(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != 0)
            {


                Cliente productoModificado = new Cliente
                {
                    IdCliente = Convert.ToInt32(textBox1.Text),
                    NombreCliente = txt_nombreCompleto.Text,
                    Cedula = text_cedula.Text,
                    Direccion = text_direccion.Text,
                    Correo = text_correo.Text,
                };

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        string query = "UPDATE cliente SET nombre_completo = @nombre, cedula = @cedula, " +
                                       "direccion = @direccion, correo = @correo " +
                                       "WHERE id_cliente = @idCliente";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombre", productoModificado.NombreCliente);
                        command.Parameters.AddWithValue("@cedula", productoModificado.Cedula);
                        command.Parameters.AddWithValue("@direccion", productoModificado.Direccion);
                        command.Parameters.AddWithValue("@correo", productoModificado.Correo);
                        command.Parameters.AddWithValue("@idCliente", productoModificado.IdCliente);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto actualizado correctamente.");
                    MostrarClientes(); // Actualizar la vista de los productos
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

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != 0)
            {

                int idCliente = Convert.ToInt32(textBox1.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Eliminar el empleado
                        string query = "DELETE FROM cliente WHERE id_cliente = @idCliente";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente eliminado correctamente.");
                    MostrarClientes();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
        }
    }  
}
