namespace Tarea2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFabricantes = new System.Windows.Forms.ListBox();
            this.btnMostrarFabricantes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbProductos = new System.Windows.Forms.RadioButton();
            this.rbFabricantes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResultados = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lstFabricantes2 = new System.Windows.Forms.ListBox();
            this.lstProductos2 = new System.Windows.Forms.ListBox();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnBorrarFabricante = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbConsultas = new System.Windows.Forms.ComboBox();
            this.lstConsultas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tiendaDataSet = new Tarea2.tiendaDataSet();
            this.tiendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstProductos);
            this.panel1.Controls.Add(this.btnMostrarProductos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 299);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ejercicio 1";
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 19;
            this.lstProductos.Location = new System.Drawing.Point(26, 40);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(479, 194);
            this.lstProductos.TabIndex = 1;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMostrarProductos.Location = new System.Drawing.Point(337, 240);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(168, 52);
            this.btnMostrarProductos.TabIndex = 0;
            this.btnMostrarProductos.Text = "Mostrar productos ";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lstFabricantes);
            this.panel2.Controls.Add(this.btnMostrarFabricantes);
            this.panel2.Location = new System.Drawing.Point(550, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 299);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ejercicio 2";
            // 
            // lstFabricantes
            // 
            this.lstFabricantes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstFabricantes.FormattingEnabled = true;
            this.lstFabricantes.ItemHeight = 19;
            this.lstFabricantes.Location = new System.Drawing.Point(26, 40);
            this.lstFabricantes.Name = "lstFabricantes";
            this.lstFabricantes.Size = new System.Drawing.Size(479, 194);
            this.lstFabricantes.TabIndex = 1;
            // 
            // btnMostrarFabricantes
            // 
            this.btnMostrarFabricantes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMostrarFabricantes.Location = new System.Drawing.Point(337, 240);
            this.btnMostrarFabricantes.Name = "btnMostrarFabricantes";
            this.btnMostrarFabricantes.Size = new System.Drawing.Size(168, 52);
            this.btnMostrarFabricantes.TabIndex = 0;
            this.btnMostrarFabricantes.Text = "Mostrar fabricantes";
            this.btnMostrarFabricantes.UseVisualStyleBackColor = true;
            this.btnMostrarFabricantes.Click += new System.EventHandler(this.btnMostrarFabricantes_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbOpciones);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rbProductos);
            this.panel3.Controls.Add(this.rbFabricantes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbResultados);
            this.panel3.Location = new System.Drawing.Point(12, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 299);
            this.panel3.TabIndex = 0;
            // 
            // cbOpciones
            // 
            this.cbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpciones.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Location = new System.Drawing.Point(165, 264);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(195, 27);
            this.cbOpciones.TabIndex = 7;
            this.cbOpciones.SelectedIndexChanged += new System.EventHandler(this.cbOpciones_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(162, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opciones";
            // 
            // rbProductos
            // 
            this.rbProductos.AutoSize = true;
            this.rbProductos.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbProductos.Location = new System.Drawing.Point(26, 264);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(97, 23);
            this.rbProductos.TabIndex = 5;
            this.rbProductos.Text = "Productos";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // rbFabricantes
            // 
            this.rbFabricantes.AutoSize = true;
            this.rbFabricantes.Checked = true;
            this.rbFabricantes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbFabricantes.Location = new System.Drawing.Point(26, 240);
            this.rbFabricantes.Name = "rbFabricantes";
            this.rbFabricantes.Size = new System.Drawing.Size(106, 23);
            this.rbFabricantes.TabIndex = 4;
            this.rbFabricantes.TabStop = true;
            this.rbFabricantes.Text = "Fabricantes";
            this.rbFabricantes.UseVisualStyleBackColor = true;
            this.rbFabricantes.CheckedChanged += new System.EventHandler(this.rbFabricantes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ejercicio 3";
            // 
            // tbResultados
            // 
            this.tbResultados.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbResultados.Location = new System.Drawing.Point(26, 40);
            this.tbResultados.Multiline = true;
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.Size = new System.Drawing.Size(479, 194);
            this.tbResultados.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lstFabricantes2);
            this.panel4.Controls.Add(this.lstProductos2);
            this.panel4.Controls.Add(this.btnBorrarProducto);
            this.panel4.Controls.Add(this.btnBorrarFabricante);
            this.panel4.Location = new System.Drawing.Point(550, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 299);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.Location = new System.Drawing.Point(21, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ejercicio 4";
            // 
            // lstFabricantes2
            // 
            this.lstFabricantes2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstFabricantes2.FormattingEnabled = true;
            this.lstFabricantes2.ItemHeight = 19;
            this.lstFabricantes2.Location = new System.Drawing.Point(308, 40);
            this.lstFabricantes2.Name = "lstFabricantes2";
            this.lstFabricantes2.Size = new System.Drawing.Size(197, 194);
            this.lstFabricantes2.TabIndex = 5;
            // 
            // lstProductos2
            // 
            this.lstProductos2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstProductos2.FormattingEnabled = true;
            this.lstProductos2.ItemHeight = 19;
            this.lstProductos2.Location = new System.Drawing.Point(26, 40);
            this.lstProductos2.Name = "lstProductos2";
            this.lstProductos2.Size = new System.Drawing.Size(197, 194);
            this.lstProductos2.TabIndex = 6;
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBorrarProducto.Location = new System.Drawing.Point(84, 240);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(81, 45);
            this.btnBorrarProducto.TabIndex = 4;
            this.btnBorrarProducto.Text = "Borrar";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnBorrarFabricante
            // 
            this.btnBorrarFabricante.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBorrarFabricante.Location = new System.Drawing.Point(366, 240);
            this.btnBorrarFabricante.Name = "btnBorrarFabricante";
            this.btnBorrarFabricante.Size = new System.Drawing.Size(81, 45);
            this.btnBorrarFabricante.TabIndex = 3;
            this.btnBorrarFabricante.Text = "Borrar";
            this.btnBorrarFabricante.UseVisualStyleBackColor = true;
            this.btnBorrarFabricante.Click += new System.EventHandler(this.btnBorrarFabricante_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbConsultas);
            this.panel5.Controls.Add(this.lstConsultas);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 622);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1065, 214);
            this.panel5.TabIndex = 2;
            // 
            // cbConsultas
            // 
            this.cbConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsultas.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbConsultas.FormattingEnabled = true;
            this.cbConsultas.Location = new System.Drawing.Point(22, 52);
            this.cbConsultas.Name = "cbConsultas";
            this.cbConsultas.Size = new System.Drawing.Size(536, 27);
            this.cbConsultas.TabIndex = 7;
            this.cbConsultas.SelectedIndexChanged += new System.EventHandler(this.cbConsultas_SelectedIndexChanged);
            // 
            // lstConsultas
            // 
            this.lstConsultas.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstConsultas.FormattingEnabled = true;
            this.lstConsultas.ItemHeight = 19;
            this.lstConsultas.Location = new System.Drawing.Point(564, 12);
            this.lstConsultas.Name = "lstConsultas";
            this.lstConsultas.Size = new System.Drawing.Size(479, 194);
            this.lstConsultas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.Location = new System.Drawing.Point(17, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ejercicio 5";
            // 
            // tiendaDataSet
            // 
            this.tiendaDataSet.DataSetName = "tiendaDataSet";
            this.tiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiendaDataSetBindingSource
            // 
            this.tiendaDataSetBindingSource.DataSource = this.tiendaDataSet;
            this.tiendaDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 837);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFabricantes;
        private System.Windows.Forms.Button btnMostrarFabricantes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbProductos;
        private System.Windows.Forms.RadioButton rbFabricantes;
        private System.Windows.Forms.TextBox tbResultados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOpciones;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lstFabricantes2;
        private System.Windows.Forms.ListBox lstProductos2;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnBorrarFabricante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbConsultas;
        private System.Windows.Forms.ListBox lstConsultas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource tiendaDataSetBindingSource;
        private tiendaDataSet tiendaDataSet;
    }
}

