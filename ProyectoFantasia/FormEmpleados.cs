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
    public partial class FormEmpleados : Form
    {
       
        public FormEmpleados()
        {
            InitializeComponent();
           
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
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

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
