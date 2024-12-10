namespace Actividad7
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
            this.txtDatosInsertados = new System.Windows.Forms.TextBox();
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            this.btnMostrarInfoFichero = new System.Windows.Forms.Button();
            this.txtDatosFichero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDatosInsertados
            // 
            this.txtDatosInsertados.Location = new System.Drawing.Point(111, 258);
            this.txtDatosInsertados.Name = "txtDatosInsertados";
            this.txtDatosInsertados.Size = new System.Drawing.Size(204, 22);
            this.txtDatosInsertados.TabIndex = 0;
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(151, 302);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(118, 60);
            this.btnInsertarDatos.TabIndex = 1;
            this.btnInsertarDatos.Text = "Insertar datos";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            this.btnInsertarDatos.Click += new System.EventHandler(this.btnInsertarDatos_Click);
            // 
            // btnMostrarInfoFichero
            // 
            this.btnMostrarInfoFichero.Location = new System.Drawing.Point(712, 239);
            this.btnMostrarInfoFichero.Name = "btnMostrarInfoFichero";
            this.btnMostrarInfoFichero.Size = new System.Drawing.Size(118, 60);
            this.btnMostrarInfoFichero.TabIndex = 2;
            this.btnMostrarInfoFichero.Text = "Ver datos";
            this.btnMostrarInfoFichero.UseVisualStyleBackColor = true;
            this.btnMostrarInfoFichero.Click += new System.EventHandler(this.btnMostrarInfoFichero_Click);
            // 
            // txtDatosFichero
            // 
            this.txtDatosFichero.Location = new System.Drawing.Point(632, 334);
            this.txtDatosFichero.Multiline = true;
            this.txtDatosFichero.Name = "txtDatosFichero";
            this.txtDatosFichero.ReadOnly = true;
            this.txtDatosFichero.Size = new System.Drawing.Size(282, 243);
            this.txtDatosFichero.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 624);
            this.Controls.Add(this.txtDatosFichero);
            this.Controls.Add(this.btnMostrarInfoFichero);
            this.Controls.Add(this.btnInsertarDatos);
            this.Controls.Add(this.txtDatosInsertados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatosInsertados;
        private System.Windows.Forms.Button btnInsertarDatos;
        private System.Windows.Forms.Button btnMostrarInfoFichero;
        private System.Windows.Forms.TextBox txtDatosFichero;
    }
}

