namespace Actividad4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbPrecio = new TextBox();
            tbStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btGuardar = new Button();
            dgvProductos = new DataGridView();
            panel2 = new Panel();
            btGuardarProductoPanaderia = new Button();
            label8 = new Label();
            label4 = new Label();
            cbProducto = new ComboBox();
            cbPanaderia = new ComboBox();
            panel1 = new Panel();
            gbPanadería = new GroupBox();
            btGuardarPanaderia = new Button();
            tbNombrePanaderia = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbDireccion = new TextBox();
            label7 = new Label();
            tbTelefono = new TextBox();
            gbProducto = new GroupBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            dgvPanaderiaProductos = new DataGridView();
            panel5 = new Panel();
            dgvPanaderia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            gbPanadería.SuspendLayout();
            gbProducto.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderiaProductos).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanaderia).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(87, 32);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(105, 443);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(121, 23);
            tbPrecio.TabIndex = 1;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(105, 472);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(121, 23);
            tbStock.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 451);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 480);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Stock";
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(71, 100);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 6;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(727, 175);
            dgvProductos.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btGuardarProductoPanaderia);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbPrecio);
            panel2.Controls.Add(cbProducto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbPanaderia);
            panel2.Controls.Add(tbStock);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(gbProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 609);
            panel2.TabIndex = 12;
            // 
            // btGuardarProductoPanaderia
            // 
            btGuardarProductoPanaderia.Location = new Point(87, 519);
            btGuardarProductoPanaderia.Name = "btGuardarProductoPanaderia";
            btGuardarProductoPanaderia.Size = new Size(75, 23);
            btGuardarProductoPanaderia.TabIndex = 12;
            btGuardarProductoPanaderia.Text = "Guardar";
            btGuardarProductoPanaderia.UseVisualStyleBackColor = true;
            btGuardarProductoPanaderia.Click += btGuardarProductoPanaderia_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 422);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 17;
            label8.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 393);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "Panadería";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(105, 414);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(121, 23);
            cbProducto.TabIndex = 16;
            // 
            // cbPanaderia
            // 
            cbPanaderia.FormattingEnabled = true;
            cbPanaderia.Location = new Point(105, 385);
            cbPanaderia.Name = "cbPanaderia";
            cbPanaderia.Size = new Size(121, 23);
            cbPanaderia.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(gbPanadería);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 189);
            panel1.TabIndex = 14;
            // 
            // gbPanadería
            // 
            gbPanadería.Controls.Add(btGuardarPanaderia);
            gbPanadería.Controls.Add(tbNombrePanaderia);
            gbPanadería.Controls.Add(label5);
            gbPanadería.Controls.Add(label6);
            gbPanadería.Controls.Add(tbDireccion);
            gbPanadería.Controls.Add(label7);
            gbPanadería.Controls.Add(tbTelefono);
            gbPanadería.Dock = DockStyle.Fill;
            gbPanadería.Location = new Point(0, 0);
            gbPanadería.Name = "gbPanadería";
            gbPanadería.Size = new Size(978, 189);
            gbPanadería.TabIndex = 13;
            gbPanadería.TabStop = false;
            gbPanadería.Text = "Panadería";
            // 
            // btGuardarPanaderia
            // 
            btGuardarPanaderia.Location = new Point(71, 137);
            btGuardarPanaderia.Name = "btGuardarPanaderia";
            btGuardarPanaderia.Size = new Size(75, 23);
            btGuardarPanaderia.TabIndex = 11;
            btGuardarPanaderia.Text = "Guardar";
            btGuardarPanaderia.UseVisualStyleBackColor = true;
            btGuardarPanaderia.Click += btGuardarPanaderia_Click;
            // 
            // tbNombrePanaderia
            // 
            tbNombrePanaderia.Location = new Point(95, 37);
            tbNombrePanaderia.Name = "tbNombrePanaderia";
            tbNombrePanaderia.Size = new Size(100, 23);
            tbNombrePanaderia.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 40);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 102);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Teléfono";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(95, 65);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(100, 23);
            tbDireccion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 73);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Dirección";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(95, 94);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(100, 23);
            tbTelefono.TabIndex = 8;
            // 
            // gbProducto
            // 
            gbProducto.Controls.Add(tbNombre);
            gbProducto.Controls.Add(label1);
            gbProducto.Controls.Add(btGuardar);
            gbProducto.Dock = DockStyle.Top;
            gbProducto.Location = new Point(0, 0);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(978, 175);
            gbProducto.TabIndex = 12;
            gbProducto.TabStop = false;
            gbProducto.Text = "Producto";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProductos);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 175);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(251, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 609);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvPanaderiaProductos);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 362);
            panel6.Name = "panel6";
            panel6.Size = new Size(727, 247);
            panel6.TabIndex = 13;
            // 
            // dgvPanaderiaProductos
            // 
            dgvPanaderiaProductos.AllowUserToAddRows = false;
            dgvPanaderiaProductos.AllowUserToDeleteRows = false;
            dgvPanaderiaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanaderiaProductos.Dock = DockStyle.Fill;
            dgvPanaderiaProductos.Location = new Point(0, 0);
            dgvPanaderiaProductos.Name = "dgvPanaderiaProductos";
            dgvPanaderiaProductos.ReadOnly = true;
            dgvPanaderiaProductos.Size = new Size(727, 247);
            dgvPanaderiaProductos.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvPanaderia);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 175);
            panel5.Name = "panel5";
            panel5.Size = new Size(727, 434);
            panel5.TabIndex = 12;
            // 
            // dgvPanaderia
            // 
            dgvPanaderia.AllowUserToAddRows = false;
            dgvPanaderia.AllowUserToDeleteRows = false;
            dgvPanaderia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanaderia.Dock = DockStyle.Fill;
            dgvPanaderia.Location = new Point(0, 0);
            dgvPanaderia.Name = "dgvPanaderia";
            dgvPanaderia.ReadOnly = true;
            dgvPanaderia.Size = new Size(727, 434);
            dgvPanaderia.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 609);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            gbPanadería.ResumeLayout(false);
            gbPanadería.PerformLayout();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPanaderiaProductos).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPanaderia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbPrecio;
        private TextBox tbStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btGuardar;
        private DataGridView dgvProductos;
        private Panel panel2;
        private GroupBox gbPanadería;
        private TextBox tbNombrePanaderia;
        private Label label5;
        private Label label6;
        private TextBox tbDireccion;
        private Label label7;
        private TextBox tbTelefono;
        private GroupBox gbProducto;
        private Panel panel1;
        private Button btGuardarPanaderia;
        private Button btGuardarProductoPanaderia;
        private Label label8;
        private Label label4;
        private ComboBox cbProducto;
        private ComboBox cbPanaderia;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private DataGridView dgvPanaderiaProductos;
        private Panel panel5;
        private DataGridView dgvPanaderia;
    }
}
