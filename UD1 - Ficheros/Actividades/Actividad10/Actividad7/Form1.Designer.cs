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
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            this.btnMostrarInfoFichero = new System.Windows.Forms.Button();
            this.txtDatosFichero = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtRutaDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefinirRuta = new System.Windows.Forms.Button();
            this.txtNombreFichero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(594, 239);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(118, 60);
            this.btnInsertarDatos.TabIndex = 1;
            this.btnInsertarDatos.Text = "Insertar datos";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            this.btnInsertarDatos.Click += new System.EventHandler(this.btnInsertarDatos_Click);
            // 
            // btnMostrarInfoFichero
            // 
            this.btnMostrarInfoFichero.Location = new System.Drawing.Point(946, 239);
            this.btnMostrarInfoFichero.Name = "btnMostrarInfoFichero";
            this.btnMostrarInfoFichero.Size = new System.Drawing.Size(118, 60);
            this.btnMostrarInfoFichero.TabIndex = 2;
            this.btnMostrarInfoFichero.Text = "Ver datos";
            this.btnMostrarInfoFichero.UseVisualStyleBackColor = true;
            this.btnMostrarInfoFichero.Click += new System.EventHandler(this.btnMostrarInfoFichero_Click);
            // 
            // txtDatosFichero
            // 
            this.txtDatosFichero.Location = new System.Drawing.Point(865, 350);
            this.txtDatosFichero.Multiline = true;
            this.txtDatosFichero.Name = "txtDatosFichero";
            this.txtDatosFichero.ReadOnly = true;
            this.txtDatosFichero.Size = new System.Drawing.Size(282, 243);
            this.txtDatosFichero.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(564, 428);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(564, 490);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 16);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(664, 425);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(664, 484);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 22);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtRutaDirectorio
            // 
            this.txtRutaDirectorio.Location = new System.Drawing.Point(191, 456);
            this.txtRutaDirectorio.Name = "txtRutaDirectorio";
            this.txtRutaDirectorio.Size = new System.Drawing.Size(100, 22);
            this.txtRutaDirectorio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta directorio";
            // 
            // btnDefinirRuta
            // 
            this.btnDefinirRuta.Location = new System.Drawing.Point(173, 239);
            this.btnDefinirRuta.Name = "btnDefinirRuta";
            this.btnDefinirRuta.Size = new System.Drawing.Size(118, 60);
            this.btnDefinirRuta.TabIndex = 10;
            this.btnDefinirRuta.Text = "Definir ruta";
            this.btnDefinirRuta.UseVisualStyleBackColor = true;
            this.btnDefinirRuta.Click += new System.EventHandler(this.btnDefinirRuta_Click);
            // 
            // txtNombreFichero
            // 
            this.txtNombreFichero.Location = new System.Drawing.Point(191, 502);
            this.txtNombreFichero.Name = "txtNombreFichero";
            this.txtNombreFichero.Size = new System.Drawing.Size(100, 22);
            this.txtNombreFichero.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre fichero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 624);
            this.Controls.Add(this.txtNombreFichero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDefinirRuta);
            this.Controls.Add(this.txtRutaDirectorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDatosFichero);
            this.Controls.Add(this.btnMostrarInfoFichero);
            this.Controls.Add(this.btnInsertarDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertarDatos;
        private System.Windows.Forms.Button btnMostrarInfoFichero;
        private System.Windows.Forms.TextBox txtDatosFichero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtRutaDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDefinirRuta;
        private System.Windows.Forms.TextBox txtNombreFichero;
        private System.Windows.Forms.Label label2;
    }
}

