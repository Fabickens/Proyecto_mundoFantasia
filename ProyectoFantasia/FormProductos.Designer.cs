namespace ProyectoFantasia
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.seleccionarbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.text_disponibles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_precioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_precioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionarbtn});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(401, 107);
            this.dataGridViewEmpleados.MultiSelect = false;
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(725, 432);
            this.dataGridViewEmpleados.TabIndex = 31;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // seleccionarbtn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seleccionarbtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.seleccionarbtn.HeaderText = "";
            this.seleccionarbtn.Name = "seleccionarbtn";
            this.seleccionarbtn.ReadOnly = true;
            this.seleccionarbtn.Width = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonEliminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.ForeColor = System.Drawing.Color.Black;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(177, 424);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 64);
            this.botonEliminar.TabIndex = 27;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonEliminar.UseVisualStyleBackColor = false;
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonGuardar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.Color.Black;
            this.botonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botonGuardar.Image")));
            this.botonGuardar.Location = new System.Drawing.Point(96, 424);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 64);
            this.botonGuardar.TabIndex = 28;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonGuardar.UseVisualStyleBackColor = false;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonLimpiar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.ForeColor = System.Drawing.Color.Black;
            this.botonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("botonLimpiar.Image")));
            this.botonLimpiar.Location = new System.Drawing.Point(14, 424);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 64);
            this.botonLimpiar.TabIndex = 29;
            this.botonLimpiar.Text = "Editar";
            this.botonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonLimpiar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(37, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 71);
            this.label6.TabIndex = 26;
            this.label6.Text = "Productos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreProducto.Location = new System.Drawing.Point(25, 183);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(210, 20);
            this.txt_nombreProducto.TabIndex = 25;
            // 
            // text_descripcion
            // 
            this.text_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_descripcion.Location = new System.Drawing.Point(25, 232);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(210, 20);
            this.text_descripcion.TabIndex = 24;
            // 
            // text_codigo
            // 
            this.text_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_codigo.Location = new System.Drawing.Point(25, 134);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(210, 20);
            this.text_codigo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descripcion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre Producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo de producto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 622);
            this.label1.TabIndex = 19;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 33;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.LightGray;
            this.Titulo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Yellow;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(401, 11);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(286, 79);
            this.Titulo.TabIndex = 32;
            this.Titulo.Text = "Lista de productos";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_disponibles
            // 
            this.text_disponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_disponibles.Location = new System.Drawing.Point(25, 281);
            this.text_disponibles.Name = "text_disponibles";
            this.text_disponibles.Size = new System.Drawing.Size(210, 20);
            this.text_disponibles.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Disponibles:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_precioVenta
            // 
            this.text_precioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_precioVenta.Location = new System.Drawing.Point(25, 379);
            this.text_precioVenta.Name = "text_precioVenta";
            this.text_precioVenta.Size = new System.Drawing.Size(210, 20);
            this.text_precioVenta.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Precio Venta:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_precioCompra
            // 
            this.text_precioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_precioCompra.Location = new System.Drawing.Point(25, 330);
            this.text_precioCompra.Name = "text_precioCompra";
            this.text_precioCompra.Size = new System.Drawing.Size(210, 20);
            this.text_precioCompra.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Precio Compra";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 622);
            this.Controls.Add(this.text_precioCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_precioVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_disponibles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombreProducto);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Titulo);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionarbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox text_disponibles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_precioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_precioCompra;
        private System.Windows.Forms.Label label8;
    }
}