namespace Actividad4
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
            this.lstFutbolistas = new System.Windows.Forms.ListBox();
            this.btnMostrarFutbolistas = new System.Windows.Forms.Button();
            this.panelVisualizacion = new System.Windows.Forms.Panel();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.btnBorrarFutbolista = new System.Windows.Forms.Button();
            this.btnMostrarEquipos = new System.Windows.Forms.Button();
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertarEquipo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.btnInsertarFutbolista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipoFutbolista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
            this.panelVisualizacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFutbolistas
            // 
            this.lstFutbolistas.FormattingEnabled = true;
            this.lstFutbolistas.ItemHeight = 16;
            this.lstFutbolistas.Location = new System.Drawing.Point(28, 29);
            this.lstFutbolistas.Name = "lstFutbolistas";
            this.lstFutbolistas.Size = new System.Drawing.Size(253, 340);
            this.lstFutbolistas.TabIndex = 0;
            // 
            // btnMostrarFutbolistas
            // 
            this.btnMostrarFutbolistas.Location = new System.Drawing.Point(71, 387);
            this.btnMostrarFutbolistas.Name = "btnMostrarFutbolistas";
            this.btnMostrarFutbolistas.Size = new System.Drawing.Size(139, 56);
            this.btnMostrarFutbolistas.TabIndex = 1;
            this.btnMostrarFutbolistas.Text = "Mostrar futbolistas";
            this.btnMostrarFutbolistas.UseVisualStyleBackColor = true;
            this.btnMostrarFutbolistas.Click += new System.EventHandler(this.btnMostrarFutbolistas_Click);
            // 
            // panelVisualizacion
            // 
            this.panelVisualizacion.Controls.Add(this.btnBorrarEquipo);
            this.panelVisualizacion.Controls.Add(this.btnBorrarFutbolista);
            this.panelVisualizacion.Controls.Add(this.btnMostrarEquipos);
            this.panelVisualizacion.Controls.Add(this.lstEquipos);
            this.panelVisualizacion.Controls.Add(this.lstFutbolistas);
            this.panelVisualizacion.Controls.Add(this.btnMostrarFutbolistas);
            this.panelVisualizacion.Location = new System.Drawing.Point(12, 35);
            this.panelVisualizacion.Name = "panelVisualizacion";
            this.panelVisualizacion.Size = new System.Drawing.Size(647, 566);
            this.panelVisualizacion.TabIndex = 2;
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(388, 469);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(139, 56);
            this.btnBorrarEquipo.TabIndex = 6;
            this.btnBorrarEquipo.Text = "Borrar equipo";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // btnBorrarFutbolista
            // 
            this.btnBorrarFutbolista.Location = new System.Drawing.Point(71, 469);
            this.btnBorrarFutbolista.Name = "btnBorrarFutbolista";
            this.btnBorrarFutbolista.Size = new System.Drawing.Size(139, 56);
            this.btnBorrarFutbolista.TabIndex = 5;
            this.btnBorrarFutbolista.Text = "Borrar futbolista";
            this.btnBorrarFutbolista.UseVisualStyleBackColor = true;
            this.btnBorrarFutbolista.Click += new System.EventHandler(this.btnBorrarFutbolista_Click);
            // 
            // btnMostrarEquipos
            // 
            this.btnMostrarEquipos.Location = new System.Drawing.Point(388, 387);
            this.btnMostrarEquipos.Name = "btnMostrarEquipos";
            this.btnMostrarEquipos.Size = new System.Drawing.Size(139, 56);
            this.btnMostrarEquipos.TabIndex = 4;
            this.btnMostrarEquipos.Text = "Mostrar equipos";
            this.btnMostrarEquipos.UseVisualStyleBackColor = true;
            this.btnMostrarEquipos.Click += new System.EventHandler(this.btnMostrarEquipos_Click);
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(345, 29);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(253, 340);
            this.lstEquipos.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnInsertarEquipo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEstadio);
            this.panel1.Controls.Add(this.txtNombreEquipo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCodigoEquipo);
            this.panel1.Controls.Add(this.btnInsertarFutbolista);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEquipoFutbolista);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreFutbolista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodigoFutbolista);
            this.panel1.Location = new System.Drawing.Point(744, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 566);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // btnInsertarEquipo
            // 
            this.btnInsertarEquipo.Location = new System.Drawing.Point(454, 421);
            this.btnInsertarEquipo.Name = "btnInsertarEquipo";
            this.btnInsertarEquipo.Size = new System.Drawing.Size(114, 59);
            this.btnInsertarEquipo.TabIndex = 13;
            this.btnInsertarEquipo.Text = "Insertar equipo";
            this.btnInsertarEquipo.UseVisualStyleBackColor = true;
            this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estadio";
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(515, 242);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(124, 22);
            this.txtEstadio.TabIndex = 11;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(515, 172);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(124, 22);
            this.txtNombreEquipo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Codigo";
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Location = new System.Drawing.Point(515, 110);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(124, 22);
            this.txtCodigoEquipo.TabIndex = 7;
            // 
            // btnInsertarFutbolista
            // 
            this.btnInsertarFutbolista.Location = new System.Drawing.Point(100, 421);
            this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
            this.btnInsertarFutbolista.Size = new System.Drawing.Size(114, 59);
            this.btnInsertarFutbolista.TabIndex = 6;
            this.btnInsertarFutbolista.Text = "Insertar futbolista";
            this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
            this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipo";
            // 
            // txtEquipoFutbolista
            // 
            this.txtEquipoFutbolista.Location = new System.Drawing.Point(161, 242);
            this.txtEquipoFutbolista.Name = "txtEquipoFutbolista";
            this.txtEquipoFutbolista.Size = new System.Drawing.Size(124, 22);
            this.txtEquipoFutbolista.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtNombreFutbolista
            // 
            this.txtNombreFutbolista.Location = new System.Drawing.Point(161, 172);
            this.txtNombreFutbolista.Name = "txtNombreFutbolista";
            this.txtNombreFutbolista.Size = new System.Drawing.Size(124, 22);
            this.txtNombreFutbolista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txtCodigoFutbolista
            // 
            this.txtCodigoFutbolista.Location = new System.Drawing.Point(161, 110);
            this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            this.txtCodigoFutbolista.Size = new System.Drawing.Size(124, 22);
            this.txtCodigoFutbolista.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVisualizacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelVisualizacion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFutbolistas;
        private System.Windows.Forms.Button btnMostrarFutbolistas;
        private System.Windows.Forms.Panel panelVisualizacion;
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.Button btnBorrarFutbolista;
        private System.Windows.Forms.Button btnMostrarEquipos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoEquipo;
        private System.Windows.Forms.Button btnInsertarFutbolista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipoFutbolista;
    }
}

