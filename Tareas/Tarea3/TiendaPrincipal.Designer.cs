namespace Tarea03Pokemon
{
    partial class TiendaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiendaPrincipal));
            this.lbFabricantes = new System.Windows.Forms.ListBox();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.btBorrarFabricante = new System.Windows.Forms.Button();
            this.btBorrarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResultadoBusqueda = new System.Windows.Forms.TextBox();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.rbFabricante = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTextoAbuscar = new System.Windows.Forms.TextBox();
            this.btRefrescarFabricantes = new System.Windows.Forms.Button();
            this.btRefrescarProductos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFabricantes
            // 
            this.lbFabricantes.FormattingEnabled = true;
            this.lbFabricantes.Location = new System.Drawing.Point(471, 24);
            this.lbFabricantes.Name = "lbFabricantes";
            this.lbFabricantes.Size = new System.Drawing.Size(190, 342);
            this.lbFabricantes.TabIndex = 0;
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(670, 24);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(284, 342);
            this.lbProductos.TabIndex = 1;
            // 
            // btBorrarFabricante
            // 
            this.btBorrarFabricante.BackColor = System.Drawing.SystemColors.Window;
            this.btBorrarFabricante.ForeColor = System.Drawing.Color.Coral;
            this.btBorrarFabricante.Image = ((System.Drawing.Image)(resources.GetObject("btBorrarFabricante.Image")));
            this.btBorrarFabricante.Location = new System.Drawing.Point(471, 372);
            this.btBorrarFabricante.Name = "btBorrarFabricante";
            this.btBorrarFabricante.Size = new System.Drawing.Size(36, 32);
            this.btBorrarFabricante.TabIndex = 9;
            this.btBorrarFabricante.UseVisualStyleBackColor = false;
            this.btBorrarFabricante.Click += new System.EventHandler(this.btBorrarFabricante_Click);
            // 
            // btBorrarProducto
            // 
            this.btBorrarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBorrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btBorrarProducto.Image")));
            this.btBorrarProducto.Location = new System.Drawing.Point(670, 372);
            this.btBorrarProducto.Name = "btBorrarProducto";
            this.btBorrarProducto.Size = new System.Drawing.Size(38, 32);
            this.btBorrarProducto.TabIndex = 10;
            this.btBorrarProducto.UseVisualStyleBackColor = false;
            this.btBorrarProducto.Click += new System.EventHandler(this.btBorrarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fabricantes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbResultadoBusqueda);
            this.groupBox1.Controls.Add(this.rbProducto);
            this.groupBox1.Controls.Add(this.rbFabricante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTextoAbuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 504);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zona de Busqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nos muestra los datos según vamos encribiendo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Zona Busqueda:";
            // 
            // tbResultadoBusqueda
            // 
            this.tbResultadoBusqueda.Location = new System.Drawing.Point(19, 99);
            this.tbResultadoBusqueda.Multiline = true;
            this.tbResultadoBusqueda.Name = "tbResultadoBusqueda";
            this.tbResultadoBusqueda.Size = new System.Drawing.Size(286, 229);
            this.tbResultadoBusqueda.TabIndex = 14;
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(19, 76);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(104, 17);
            this.rbProducto.TabIndex = 12;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Buscar Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // rbFabricante
            // 
            this.rbFabricante.AutoSize = true;
            this.rbFabricante.Location = new System.Drawing.Point(19, 53);
            this.rbFabricante.Name = "rbFabricante";
            this.rbFabricante.Size = new System.Drawing.Size(111, 17);
            this.rbFabricante.TabIndex = 11;
            this.rbFabricante.TabStop = true;
            this.rbFabricante.Text = "Buscar Fabricante";
            this.rbFabricante.UseVisualStyleBackColor = true;
            this.rbFabricante.CheckedChanged += new System.EventHandler(this.rbFabricante_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // tbTextoAbuscar
            // 
            this.tbTextoAbuscar.Location = new System.Drawing.Point(19, 26);
            this.tbTextoAbuscar.Name = "tbTextoAbuscar";
            this.tbTextoAbuscar.Size = new System.Drawing.Size(220, 20);
            this.tbTextoAbuscar.TabIndex = 9;
            this.tbTextoAbuscar.TextChanged += new System.EventHandler(this.tbTextoAbuscar_TextChanged);
            // 
            // btRefrescarFabricantes
            // 
            this.btRefrescarFabricantes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefrescarFabricantes.Image = ((System.Drawing.Image)(resources.GetObject("btRefrescarFabricantes.Image")));
            this.btRefrescarFabricantes.Location = new System.Drawing.Point(514, 372);
            this.btRefrescarFabricantes.Name = "btRefrescarFabricantes";
            this.btRefrescarFabricantes.Size = new System.Drawing.Size(38, 32);
            this.btRefrescarFabricantes.TabIndex = 14;
            this.btRefrescarFabricantes.UseVisualStyleBackColor = false;
            this.btRefrescarFabricantes.Click += new System.EventHandler(this.btRefrescarFabricantes_Click);
            // 
            // btRefrescarProductos
            // 
            this.btRefrescarProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefrescarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btRefrescarProductos.Image")));
            this.btRefrescarProductos.Location = new System.Drawing.Point(714, 372);
            this.btRefrescarProductos.Name = "btRefrescarProductos";
            this.btRefrescarProductos.Size = new System.Drawing.Size(38, 32);
            this.btRefrescarProductos.TabIndex = 15;
            this.btRefrescarProductos.UseVisualStyleBackColor = false;
            this.btRefrescarProductos.Click += new System.EventHandler(this.btRefrescarProductos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Borrar: Comprueba si tiene productos, en caso afirmativo pregunta si queremos bor" +
    "rar todo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lista Fabricantes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Refrescar: Refresca los datos en caso de fallar al iniciar el formulario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Refrescar: Refresca los datos en caso de fallar al iniciar el formulario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Borrar : borra el producto seleccionado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Lista Productos";
            // 
            // TiendaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btRefrescarProductos);
            this.Controls.Add(this.btRefrescarFabricantes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBorrarProducto);
            this.Controls.Add(this.btBorrarFabricante);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.lbFabricantes);
            this.Name = "TiendaPrincipal";
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.TiendaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFabricantes;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Button btBorrarFabricante;
        private System.Windows.Forms.Button btBorrarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbResultadoBusqueda;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.RadioButton rbFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTextoAbuscar;
        private System.Windows.Forms.Button btRefrescarFabricantes;
        private System.Windows.Forms.Button btRefrescarProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}