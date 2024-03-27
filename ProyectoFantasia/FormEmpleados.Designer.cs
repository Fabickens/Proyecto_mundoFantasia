namespace ProyectoFantasia
{
    partial class FormEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cedula = new System.Windows.Forms.TextBox();
            this.text_correo = new System.Windows.Forms.TextBox();
            this.txt_nombreCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.seleccionarbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text_salario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_areaTrabajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tiendaFantasiaDataSet = new ProyectoFantasia.TiendaFantasiaDataSet();
            this.tiendaFantasiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaFantasiaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.text_indice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 608);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Cedula :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_cedula
            // 
            this.text_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_cedula.Location = new System.Drawing.Point(27, 181);
            this.text_cedula.Name = "text_cedula";
            this.text_cedula.Size = new System.Drawing.Size(210, 20);
            this.text_cedula.TabIndex = 5;
            // 
            // text_correo
            // 
            this.text_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_correo.Location = new System.Drawing.Point(27, 284);
            this.text_correo.Name = "text_correo";
            this.text_correo.Size = new System.Drawing.Size(210, 20);
            this.text_correo.TabIndex = 6;
            // 
            // txt_nombreCompleto
            // 
            this.txt_nombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreCompleto.Location = new System.Drawing.Point(27, 230);
            this.txt_nombreCompleto.Name = "txt_nombreCompleto";
            this.txt_nombreCompleto.Size = new System.Drawing.Size(210, 20);
            this.txt_nombreCompleto.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 71);
            this.label6.TabIndex = 9;
            this.label6.Text = "Empleados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonLimpiar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.ForeColor = System.Drawing.Color.Black;
            this.botonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("botonLimpiar.Image")));
            this.botonLimpiar.Location = new System.Drawing.Point(18, 408);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 64);
            this.botonLimpiar.TabIndex = 12;
            this.botonLimpiar.Text = "Editar";
            this.botonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonGuardar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.Color.Black;
            this.botonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botonGuardar.Image")));
            this.botonGuardar.Location = new System.Drawing.Point(100, 408);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 64);
            this.botonGuardar.TabIndex = 12;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.botonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonEliminar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.ForeColor = System.Drawing.Color.Black;
            this.botonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botonEliminar.Image")));
            this.botonEliminar.Location = new System.Drawing.Point(181, 408);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 64);
            this.botonEliminar.TabIndex = 12;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.seleccionarbtn,
            this.IdEmpleado,
            this.NombreCompleto,
            this.Cedula,
            this.Correo,
            this.Salario,
            this.AreaTrabajo});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(354, 107);
            this.dataGridViewEmpleados.MultiSelect = false;
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.ReadOnly = true;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(725, 432);
            this.dataGridViewEmpleados.TabIndex = 16;
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
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "IdEmpleado";
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 120;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // AreaTrabajo
            // 
            this.AreaTrabajo.DataPropertyName = "AreaTrabajo";
            this.AreaTrabajo.HeaderText = "Area de trabajo";
            this.AreaTrabajo.Name = "AreaTrabajo";
            this.AreaTrabajo.ReadOnly = true;
            this.AreaTrabajo.Width = 120;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.LightGray;
            this.Titulo.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Yellow;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Titulo.Location = new System.Drawing.Point(354, 11);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(286, 79);
            this.Titulo.TabIndex = 17;
            this.Titulo.Text = "Lista de empleados";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 18;
            // 
            // text_salario
            // 
            this.text_salario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_salario.Location = new System.Drawing.Point(27, 333);
            this.text_salario.Name = "text_salario";
            this.text_salario.Size = new System.Drawing.Size(210, 20);
            this.text_salario.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Salario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_areaTrabajo
            // 
            this.text_areaTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_areaTrabajo.Location = new System.Drawing.Point(27, 382);
            this.text_areaTrabajo.Name = "text_areaTrabajo";
            this.text_areaTrabajo.Size = new System.Drawing.Size(210, 20);
            this.text_areaTrabajo.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Area de trabajo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tiendaFantasiaDataSet
            // 
            this.tiendaFantasiaDataSet.DataSetName = "TiendaFantasiaDataSet";
            this.tiendaFantasiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiendaFantasiaDataSetBindingSource
            // 
            this.tiendaFantasiaDataSetBindingSource.DataSource = this.tiendaFantasiaDataSet;
            this.tiendaFantasiaDataSetBindingSource.Position = 0;
            // 
            // tiendaFantasiaDataSetBindingSource1
            // 
            this.tiendaFantasiaDataSetBindingSource1.DataSource = this.tiendaFantasiaDataSet;
            this.tiendaFantasiaDataSetBindingSource1.Position = 0;
            // 
            // text_indice
            // 
            this.text_indice.Location = new System.Drawing.Point(192, 136);
            this.text_indice.Name = "text_indice";
            this.text_indice.Size = new System.Drawing.Size(26, 20);
            this.text_indice.TabIndex = 23;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.text_indice);
            this.Controls.Add(this.text_areaTrabajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombreCompleto);
            this.Controls.Add(this.text_correo);
            this.Controls.Add(this.text_cedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaFantasiaDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cedula;
        private System.Windows.Forms.TextBox text_correo;
        private System.Windows.Forms.TextBox txt_nombreCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox text_salario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_areaTrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tiendaFantasiaDataSetBindingSource;
        private TiendaFantasiaDataSet tiendaFantasiaDataSet;
        private System.Windows.Forms.BindingSource tiendaFantasiaDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionarbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaTrabajo;
        private System.Windows.Forms.TextBox text_indice;
    }
}