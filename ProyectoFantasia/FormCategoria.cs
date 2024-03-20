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
    }   
}
