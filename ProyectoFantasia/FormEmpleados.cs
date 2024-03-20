using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFantasia
{
    public partial class FormEmpleados : Form
    {

        public FormEmpleados()
        {
            InitializeComponent();

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "SELECT * From empleado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmpleados.DataSource = table;
            }

            dataGridViewEmpleados.Columns["id_empleado"].Visible = false;
            dataGridViewEmpleados.Columns["nombre_completo"].HeaderText = "Nombre Completo";
            dataGridViewEmpleados.Columns["fecha_registro"].HeaderText = "Fecha Registro";
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "seleccionarbtn")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox1.Text = dataGridViewEmpleados.Rows[indice].Cells["id_empleado"].Value.ToString();
                    text_cedula.Text = dataGridViewEmpleados.Rows[indice].Cells["cedula"].Value.ToString();
                    txt_nombreCompleto.Text = dataGridViewEmpleados.Rows[indice].Cells["nombre_completo"].Value.ToString();
                    text_correo.Text = dataGridViewEmpleados.Rows[indice].Cells["correo"].Value.ToString();
                }
            }
        }            
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "Delete FROM empleado WHERE id_empleado = @Idempleado";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Idempleado", textBox1.Text);                  
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Empleado eliminado correctamente.");
                ActualizarDataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);              
            }
        }

        private void ActualizarDataGridView()
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "SELECT * FROM empleado";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmpleados.DataSource = table;
            }
        }

        private void botonGuardar_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "INSERT INTO empleado (cedula, nombre_completo, correo) VALUES (@cedula, @nombre_completo, @correo)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@cedula", text_cedula.Text);
                    command.Parameters.AddWithValue("@nombre_completo", txt_nombreCompleto.Text);
                    command.Parameters.AddWithValue("@correo", text_correo.Text);                 
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Empleado guardado correctamente.");
                ActualizarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);

            }
        }   
    }
}
