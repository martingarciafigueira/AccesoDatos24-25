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
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.txtBalanceCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.txtIBANBusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrarCuenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCuentaExistente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBalanceCuentaExistente = new System.Windows.Forms.TextBox();
            this.btnActualizarCuenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Location = new System.Drawing.Point(178, 113);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(224, 22);
            this.txtNombreCuenta.TabIndex = 1;
            // 
            // txtBalanceCuenta
            // 
            this.txtBalanceCuenta.Location = new System.Drawing.Point(229, 153);
            this.txtBalanceCuenta.Name = "txtBalanceCuenta";
            this.txtBalanceCuenta.Size = new System.Drawing.Size(173, 22);
            this.txtBalanceCuenta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance monetario";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(462, 86);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(198, 77);
            this.btnCrearCuenta.TabIndex = 4;
            this.btnCrearCuenta.Text = "Crear nueva cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCuenta.Location = new System.Drawing.Point(462, 239);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(198, 37);
            this.btnBuscarCuenta.TabIndex = 9;
            this.btnBuscarCuenta.Text = "Buscar cuenta";
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.btnBuscarCuenta_Click);
            // 
            // txtIBANBusqueda
            // 
            this.txtIBANBusqueda.Location = new System.Drawing.Point(178, 270);
            this.txtIBANBusqueda.Name = "txtIBANBusqueda";
            this.txtIBANBusqueda.Size = new System.Drawing.Size(224, 22);
            this.txtIBANBusqueda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "IBAN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBorrarCuenta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNombreCuentaExistente);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBalanceCuentaExistente);
            this.panel1.Controls.Add(this.btnActualizarCuenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIBAN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreCuenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscarCuenta);
            this.panel1.Controls.Add(this.txtBalanceCuenta);
            this.panel1.Controls.Add(this.btnCrearCuenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIBANBusqueda);
            this.panel1.Location = new System.Drawing.Point(312, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 555);
            this.panel1.TabIndex = 12;
            // 
            // btnBorrarCuenta
            // 
            this.btnBorrarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCuenta.Location = new System.Drawing.Point(462, 293);
            this.btnBorrarCuenta.Name = "btnBorrarCuenta";
            this.btnBorrarCuenta.Size = new System.Drawing.Size(198, 37);
            this.btnBorrarCuenta.TabIndex = 17;
            this.btnBorrarCuenta.Text = "Borrar cuenta";
            this.btnBorrarCuenta.UseVisualStyleBackColor = true;
            this.btnBorrarCuenta.Click += new System.EventHandler(this.btnBorrarCuenta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre";
            // 
            // txtNombreCuentaExistente
            // 
            this.txtNombreCuentaExistente.Location = new System.Drawing.Point(178, 400);
            this.txtNombreCuentaExistente.Name = "txtNombreCuentaExistente";
            this.txtNombreCuentaExistente.Size = new System.Drawing.Size(224, 22);
            this.txtNombreCuentaExistente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Balance monetario";
            // 
            // txtBalanceCuentaExistente
            // 
            this.txtBalanceCuentaExistente.Location = new System.Drawing.Point(229, 442);
            this.txtBalanceCuentaExistente.Name = "txtBalanceCuentaExistente";
            this.txtBalanceCuentaExistente.Size = new System.Drawing.Size(173, 22);
            this.txtBalanceCuentaExistente.TabIndex = 15;
            // 
            // btnActualizarCuenta
            // 
            this.btnActualizarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCuenta.Location = new System.Drawing.Point(462, 390);
            this.btnActualizarCuenta.Name = "btnActualizarCuenta";
            this.btnActualizarCuenta.Size = new System.Drawing.Size(198, 77);
            this.btnActualizarCuenta.TabIndex = 16;
            this.btnActualizarCuenta.Text = "Actualizar cuenta";
            this.btnActualizarCuenta.UseVisualStyleBackColor = true;
            this.btnActualizarCuenta.Click += new System.EventHandler(this.btnActualizarCuenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "IBAN";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(178, 71);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(224, 22);
            this.txtIBAN.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 697);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.TextBox txtBalanceCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.TextBox txtIBANBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Button btnBorrarCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCuentaExistente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBalanceCuentaExistente;
        private System.Windows.Forms.Button btnActualizarCuenta;
    }
}

