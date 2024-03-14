using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

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
    }
}
