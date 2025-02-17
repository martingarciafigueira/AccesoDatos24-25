namespace Ejercicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVelocidadMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumRuedas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstVehiculosAsociados = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVehiculoSeleccionado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabricante";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(178, 76);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(224, 22);
            this.txtFabricante.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(178, 131);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(224, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(452, 183);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(198, 77);
            this.btnAgregarVehiculo.TabIndex = 4;
            this.btnAgregarVehiculo.Text = "Agregar vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtVelocidadMax);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNumRuedas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAnho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFabricante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.btnAgregarVehiculo);
            this.panel1.Location = new System.Drawing.Point(24, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 433);
            this.panel1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Velocidad máxima";
            // 
            // txtVelocidadMax
            // 
            this.txtVelocidadMax.Location = new System.Drawing.Point(258, 347);
            this.txtVelocidadMax.Name = "txtVelocidadMax";
            this.txtVelocidadMax.Size = new System.Drawing.Size(144, 22);
            this.txtVelocidadMax.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Número de ruedas";
            // 
            // txtNumRuedas
            // 
            this.txtNumRuedas.Location = new System.Drawing.Point(258, 300);
            this.txtNumRuedas.Name = "txtNumRuedas";
            this.txtNumRuedas.Size = new System.Drawing.Size(144, 22);
            this.txtNumRuedas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // txtAnho
            // 
            this.txtAnho.Location = new System.Drawing.Point(178, 183);
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(224, 22);
            this.txtAnho.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstVehiculosAsociados);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbVehiculoSeleccionado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(753, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 648);
            this.panel2.TabIndex = 13;
            // 
            // lstVehiculosAsociados
            // 
            this.lstVehiculosAsociados.FormattingEnabled = true;
            this.lstVehiculosAsociados.ItemHeight = 16;
            this.lstVehiculosAsociados.Location = new System.Drawing.Point(260, 219);
            this.lstVehiculosAsociados.Name = "lstVehiculosAsociados";
            this.lstVehiculosAsociados.Size = new System.Drawing.Size(224, 356);
            this.lstVehiculosAsociados.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vehículos encontrados";
            // 
            // cbVehiculoSeleccionado
            // 
            this.cbVehiculoSeleccionado.FormattingEnabled = true;
            this.cbVehiculoSeleccionado.Items.AddRange(new object[] {
            "Selecciona una categoría"});
            this.cbVehiculoSeleccionado.Location = new System.Drawing.Point(260, 139);
            this.cbVehiculoSeleccionado.Name = "cbVehiculoSeleccionado";
            this.cbVehiculoSeleccionado.Size = new System.Drawing.Size(224, 24);
            this.cbVehiculoSeleccionado.TabIndex = 13;
            this.cbVehiculoSeleccionado.SelectedIndexChanged += new System.EventHandler(this.cbVehiculoSeleccionado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de vehículo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(178, 237);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(224, 24);
            this.cbTipo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstVehiculosAsociados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVehiculoSeleccionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVelocidadMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumRuedas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}

