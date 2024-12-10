namespace Actividad11
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
            this.txtRutaDirectorio = new System.Windows.Forms.TextBox();
            this.lblRutaDirectorio = new System.Windows.Forms.Label();
            this.btnCrearDirectorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoverACarpeta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtRutaDirectorio2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListarDirectorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreFichero = new System.Windows.Forms.TextBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFicheroOrigen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRutaDirectorio3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstContenidoDirectorio = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaDirectorio
            // 
            this.txtRutaDirectorio.Location = new System.Drawing.Point(127, 107);
            this.txtRutaDirectorio.Name = "txtRutaDirectorio";
            this.txtRutaDirectorio.Size = new System.Drawing.Size(259, 22);
            this.txtRutaDirectorio.TabIndex = 0;
            // 
            // lblRutaDirectorio
            // 
            this.lblRutaDirectorio.AutoSize = true;
            this.lblRutaDirectorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaDirectorio.Location = new System.Drawing.Point(60, 38);
            this.lblRutaDirectorio.Name = "lblRutaDirectorio";
            this.lblRutaDirectorio.Size = new System.Drawing.Size(307, 29);
            this.lblRutaDirectorio.TabIndex = 1;
            this.lblRutaDirectorio.Text = "Crear directorio si no existe";
            // 
            // btnCrearDirectorio
            // 
            this.btnCrearDirectorio.Location = new System.Drawing.Point(140, 162);
            this.btnCrearDirectorio.Name = "btnCrearDirectorio";
            this.btnCrearDirectorio.Size = new System.Drawing.Size(120, 34);
            this.btnCrearDirectorio.TabIndex = 2;
            this.btnCrearDirectorio.Text = "Crear directorio";
            this.btnCrearDirectorio.UseVisualStyleBackColor = true;
            this.btnCrearDirectorio.Click += new System.EventHandler(this.btnCrearDirectorio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblRutaDirectorio);
            this.panel1.Controls.Add(this.btnCrearDirectorio);
            this.panel1.Controls.Add(this.txtRutaDirectorio);
            this.panel1.Location = new System.Drawing.Point(26, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 323);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCarpetaDestino);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMoverACarpeta);
            this.panel2.Controls.Add(this.txtFicheroOrigen);
            this.panel2.Location = new System.Drawing.Point(26, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 335);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mover archivo a otro directorio";
            // 
            // btnMoverACarpeta
            // 
            this.btnMoverACarpeta.Location = new System.Drawing.Point(140, 224);
            this.btnMoverACarpeta.Name = "btnMoverACarpeta";
            this.btnMoverACarpeta.Size = new System.Drawing.Size(177, 34);
            this.btnMoverACarpeta.TabIndex = 2;
            this.btnMoverACarpeta.Text = "Mover a carpeta";
            this.btnMoverACarpeta.UseVisualStyleBackColor = true;
            this.btnMoverACarpeta.Click += new System.EventHandler(this.btnMoverACarpeta_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtContenido);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtNombreFichero);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnCrearArchivo);
            this.panel3.Controls.Add(this.txtRutaDirectorio2);
            this.panel3.Location = new System.Drawing.Point(638, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 323);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crear archivo dentro de directorio";
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(194, 272);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(120, 34);
            this.btnCrearArchivo.TabIndex = 2;
            this.btnCrearArchivo.Text = "Crear archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtRutaDirectorio2
            // 
            this.txtRutaDirectorio2.Location = new System.Drawing.Point(125, 103);
            this.txtRutaDirectorio2.Name = "txtRutaDirectorio2";
            this.txtRutaDirectorio2.Size = new System.Drawing.Size(353, 22);
            this.txtRutaDirectorio2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lstContenidoDirectorio);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtRutaDirectorio3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnListarDirectorio);
            this.panel4.Location = new System.Drawing.Point(638, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 335);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Listar el contenido de un directorio";
            // 
            // btnListarDirectorio
            // 
            this.btnListarDirectorio.Location = new System.Drawing.Point(33, 260);
            this.btnListarDirectorio.Name = "btnListarDirectorio";
            this.btnListarDirectorio.Size = new System.Drawing.Size(120, 34);
            this.btnListarDirectorio.TabIndex = 2;
            this.btnListarDirectorio.Text = "Listar directorio";
            this.btnListarDirectorio.UseVisualStyleBackColor = true;
            this.btnListarDirectorio.Click += new System.EventHandler(this.btnListarDirectorio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ruta directorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ruta directorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre fichero";
            // 
            // txtNombreFichero
            // 
            this.txtNombreFichero.Location = new System.Drawing.Point(125, 146);
            this.txtNombreFichero.Name = "txtNombreFichero";
            this.txtNombreFichero.Size = new System.Drawing.Size(353, 22);
            this.txtNombreFichero.TabIndex = 6;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(125, 188);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(353, 62);
            this.txtContenido.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contenido";
            // 
            // txtFicheroOrigen
            // 
            this.txtFicheroOrigen.Location = new System.Drawing.Point(158, 119);
            this.txtFicheroOrigen.Name = "txtFicheroOrigen";
            this.txtFicheroOrigen.Size = new System.Drawing.Size(262, 22);
            this.txtFicheroOrigen.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fichero origen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Carpeta destino";
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.Location = new System.Drawing.Point(159, 172);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.Size = new System.Drawing.Size(262, 22);
            this.txtCarpetaDestino.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ruta directorio";
            // 
            // txtRutaDirectorio3
            // 
            this.txtRutaDirectorio3.Location = new System.Drawing.Point(176, 99);
            this.txtRutaDirectorio3.Name = "txtRutaDirectorio3";
            this.txtRutaDirectorio3.Size = new System.Drawing.Size(339, 22);
            this.txtRutaDirectorio3.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contenido directorio";
            // 
            // lstContenidoDirectorio
            // 
            this.lstContenidoDirectorio.FormattingEnabled = true;
            this.lstContenidoDirectorio.ItemHeight = 16;
            this.lstContenidoDirectorio.Location = new System.Drawing.Point(176, 140);
            this.lstContenidoDirectorio.Name = "lstContenidoDirectorio";
            this.lstContenidoDirectorio.Size = new System.Drawing.Size(339, 164);
            this.lstContenidoDirectorio.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 718);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaDirectorio;
        private System.Windows.Forms.Label lblRutaDirectorio;
        private System.Windows.Forms.Button btnCrearDirectorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoverACarpeta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.TextBox txtRutaDirectorio2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListarDirectorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreFichero;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFicheroOrigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarpetaDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRutaDirectorio3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstContenidoDirectorio;
    }
}

