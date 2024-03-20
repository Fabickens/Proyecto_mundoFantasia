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
    public partial class FormCategoria : Form
    {
        
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "SELECT * From categoria";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmpleados.DataSource = table;
                
            }
            dataGridViewEmpleados.Columns["id_categoria"].Visible = false;
            dataGridViewEmpleados.Columns["descripcion"].HeaderText = "Descripcion";
            dataGridViewEmpleados.Columns["fecha_registro"].HeaderText = "Fecha Registro";
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.Columns[e.ColumnIndex].Name == "seleccionarbtn")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBox1.Text = dataGridViewEmpleados.Rows[indice].Cells["id_categoria"].Value.ToString();
                    text_cedula.Text = dataGridViewEmpleados.Rows[indice].Cells["descripcion"].Value.ToString();                   
                }
            }
        }
        private void ActualizarDataGridView()
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "SELECT * FROM categoria";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmpleados.DataSource = table;
            }
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "Delete FROM categoria WHERE id_categoria = @IdCategoria";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdCategoria", textBox1.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Categoria eliminada correctamente.");
                ActualizarDataGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoria: " + ex.Message);
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=LAPTOP-7S7U7UK3\\SQLEXPRESS; database=sistemaFantasia; integrated security=true";
            string query = "INSERT INTO categoria (descripcion) VALUES (@categoria)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@categoria", text_cedula.Text);                   
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Categoria guardada correctamente.");
                ActualizarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la categoria: " + ex.Message);

            }
        }
    }   
}
