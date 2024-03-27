using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Windows.Forms;
namespace ProyectoFantasia
{
    public partial class FormEmpleados : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        private const string ConnectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=TiendaFantasia; integrated security=true";
        private SqlConnection connection;
        

        public FormEmpleados()
        {
            InitializeComponent();
            connection = new SqlConnection(ConnectionString);
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }    
        private void ActualizarVista()
        {
             List<Empleado> empleados = new List<Empleado>();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridViewEmpleados.AutoGenerateColumns = false;
            string query = "SELECT * FROM empleado";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            empleados.Clear(); // Limpiar la lista antes de volver a cargar los datos
            while (reader.Read())
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = reader.GetInt32(0),
                    NombreCompleto = reader["nombre_completo"].ToString(),
                    Cedula = reader["cedula"].ToString(),
                    Correo = reader["correo"].ToString(),
                    Salario = decimal.Parse(reader["salario"].ToString()),
                    AreaTrabajo = reader["area_trabajo"].ToString()
                };
                empleados.Add(empleado);
            }
            reader.Close();

            // Asignar la lista de empleados como DataSource del DataGridView
            dataGridViewEmpleados.DataSource = empleados;
            dataGridViewEmpleados.Refresh(); // Refrescar el DataGr
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombreCompleto.Text;
            string cedula = text_cedula.Text;
            string correo = text_correo.Text;
            decimal salario = decimal.Parse(text_salario.Text);
            string area_trabajo = text_areaTrabajo.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Agregar el empleado
                    string query = "INSERT INTO empleado (nombre_completo, cedula, correo, salario, area_trabajo) " +
                                   "VALUES (@nombre_completo, @cedula, @correo, @salario, @area_trabajo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombre_completo", nombre);
                    command.Parameters.AddWithValue("@salario", salario);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@area_trabajo", area_trabajo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Empleado agregado correctamente.");
                ActualizarVista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmpleados.Rows[e.RowIndex];
                textBox1.Text = row.Cells["IdEmpleado"].Value.ToString();
                txt_nombreCompleto.Text = row.Cells["NombreCompleto"].Value.ToString();
                text_cedula.Text = row.Cells["Cedula"].Value.ToString();
                text_correo.Text = row.Cells["Correo"].Value.ToString();
                text_salario.Text = row.Cells["Salario"].Value.ToString();
                text_areaTrabajo.Text = row.Cells["AreaTrabajo"].Value.ToString();
                text_indice.Text = e.RowIndex.ToString();
            }
        }
     
        private void LimpiarCampos()
        {
            textBox1.Text = "";
            txt_nombreCompleto.Text = "";
            text_cedula.Text = "";
            text_correo.Text = "";
            text_salario.Text = "";
            text_areaTrabajo.Text = "";
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != 0)
            {
                
                int idEmpleado = Convert.ToInt32(textBox1.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Eliminar el empleado
                        string query = "DELETE FROM empleado WHERE id_empleado = @idEmpleado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empleado eliminado correctamente.");
                    ActualizarVista();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }
        }
    }
}
 