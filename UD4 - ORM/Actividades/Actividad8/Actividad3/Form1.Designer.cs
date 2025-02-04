namespace Actividad3
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
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFutbolistas = new System.Windows.Forms.ListBox();
            this.btnInsertarEquipos = new System.Windows.Forms.Button();
            this.txtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
            this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
            this.btnInsertarFutbolista = new System.Windows.Forms.Button();
            this.cbEquipoSeleccionado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlInfoCompletaFutbolista = new System.Windows.Forms.Panel();
            this.btnModificarFutbolista = new System.Windows.Forms.Button();
            this.cbInfoCompletaEquipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInfoCompletaNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarFutbolista = new System.Windows.Forms.Button();
            this.pnlInfoCompletaFutbolista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(27, 90);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(300, 308);
            this.lstEquipos.TabIndex = 1;
            this.lstEquipos.DoubleClick += new System.EventHandler(this.lstEquipos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Futbolistas";
            // 
            // lstFutbolistas
            // 
            this.lstFutbolistas.FormattingEnabled = true;
            this.lstFutbolistas.ItemHeight = 16;
            this.lstFutbolistas.Location = new System.Drawing.Point(426, 90);
            this.lstFutbolistas.Name = "lstFutbolistas";
            this.lstFutbolistas.Size = new System.Drawing.Size(300, 308);
            this.lstFutbolistas.TabIndex = 3;
            this.lstFutbolistas.DoubleClick += new System.EventHandler(this.lstFutbolistas_DoubleClick);
            // 
            // btnInsertarEquipos
            // 
            this.btnInsertarEquipos.Location = new System.Drawing.Point(97, 608);
            this.btnInsertarEquipos.Name = "btnInsertarEquipos";
            this.btnInsertarEquipos.Size = new System.Drawing.Size(133, 42);
            this.btnInsertarEquipos.TabIndex = 5;
            this.btnInsertarEquipos.Text = "Insertar equipos";
            this.btnInsertarEquipos.UseVisualStyleBackColor = true;
            this.btnInsertarEquipos.Click += new System.EventHandler(this.btnInsertarEquipos_Click);
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Location = new System.Drawing.Point(188, 441);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(139, 22);
            this.txtCodigoEquipo.TabIndex = 6;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(188, 491);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(139, 22);
            this.txtNombreEquipo.TabIndex = 7;
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(188, 544);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(139, 22);
            this.txtEstadio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estadio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Codigo equipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Codigo futbolista";
            // 
            // txtNombreFutbolista
            // 
            this.txtNombreFutbolista.Location = new System.Drawing.Point(588, 491);
            this.txtNombreFutbolista.Name = "txtNombreFutbolista";
            this.txtNombreFutbolista.Size = new System.Drawing.Size(139, 22);
            this.txtNombreFutbolista.TabIndex = 14;
            // 
            // txtCodigoFutbolista
            // 
            this.txtCodigoFutbolista.Location = new System.Drawing.Point(588, 441);
            this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            this.txtCodigoFutbolista.Size = new System.Drawing.Size(139, 22);
            this.txtCodigoFutbolista.TabIndex = 13;
            // 
            // btnInsertarFutbolista
            // 
            this.btnInsertarFutbolista.Location = new System.Drawing.Point(497, 608);
            this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
            this.btnInsertarFutbolista.Size = new System.Drawing.Size(133, 42);
            this.btnInsertarFutbolista.TabIndex = 12;
            this.btnInsertarFutbolista.Text = "Insertar futbolistas";
            this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
            this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
            // 
            // cbEquipoSeleccionado
            // 
            this.cbEquipoSeleccionado.FormattingEnabled = true;
            this.cbEquipoSeleccionado.Location = new System.Drawing.Point(588, 544);
            this.cbEquipoSeleccionado.Name = "cbEquipoSeleccionado";
            this.cbEquipoSeleccionado.Size = new System.Drawing.Size(139, 24);
            this.cbEquipoSeleccionado.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Info. Futbolista";
            // 
            // pnlInfoCompletaFutbolista
            // 
            this.pnlInfoCompletaFutbolista.Controls.Add(this.btnEliminarFutbolista);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.btnModificarFutbolista);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.cbInfoCompletaEquipo);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.label10);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.label11);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.txtInfoCompletaNombre);
            this.pnlInfoCompletaFutbolista.Controls.Add(this.label9);
            this.pnlInfoCompletaFutbolista.Location = new System.Drawing.Point(801, 35);
            this.pnlInfoCompletaFutbolista.Name = "pnlInfoCompletaFutbolista";
            this.pnlInfoCompletaFutbolista.Size = new System.Drawing.Size(334, 428);
            this.pnlInfoCompletaFutbolista.TabIndex = 21;
            this.pnlInfoCompletaFutbolista.Visible = false;
            // 
            // btnModificarFutbolista
            // 
            this.btnModificarFutbolista.Location = new System.Drawing.Point(99, 290);
            this.btnModificarFutbolista.Name = "btnModificarFutbolista";
            this.btnModificarFutbolista.Size = new System.Drawing.Size(133, 42);
            this.btnModificarFutbolista.TabIndex = 22;
            this.btnModificarFutbolista.Text = "Modificar futbolistas";
            this.btnModificarFutbolista.UseVisualStyleBackColor = true;
            this.btnModificarFutbolista.Click += new System.EventHandler(this.btnModificarFutbolista_Click);
            // 
            // cbInfoCompletaEquipo
            // 
            this.cbInfoCompletaEquipo.FormattingEnabled = true;
            this.cbInfoCompletaEquipo.Location = new System.Drawing.Point(181, 189);
            this.cbInfoCompletaEquipo.Name = "cbInfoCompletaEquipo";
            this.cbInfoCompletaEquipo.Size = new System.Drawing.Size(139, 24);
            this.cbInfoCompletaEquipo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Equipo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nombre";
            // 
            // txtInfoCompletaNombre
            // 
            this.txtInfoCompletaNombre.Location = new System.Drawing.Point(181, 136);
            this.txtInfoCompletaNombre.Name = "txtInfoCompletaNombre";
            this.txtInfoCompletaNombre.Size = new System.Drawing.Size(139, 22);
            this.txtInfoCompletaNombre.TabIndex = 21;
            // 
            // btnEliminarFutbolista
            // 
            this.btnEliminarFutbolista.Location = new System.Drawing.Point(99, 356);
            this.btnEliminarFutbolista.Name = "btnEliminarFutbolista";
            this.btnEliminarFutbolista.Size = new System.Drawing.Size(133, 42);
            this.btnEliminarFutbolista.TabIndex = 25;
            this.btnEliminarFutbolista.Text = "Eliminar futbolista";
            this.btnEliminarFutbolista.UseVisualStyleBackColor = true;
            this.btnEliminarFutbolista.Click += new System.EventHandler(this.btnEliminarFutbolista_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1212, 697);
            this.Controls.Add(this.pnlInfoCompletaFutbolista);
            this.Controls.Add(this.cbEquipoSeleccionado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreFutbolista);
            this.Controls.Add(this.txtCodigoFutbolista);
            this.Controls.Add(this.btnInsertarFutbolista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstadio);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.txtCodigoEquipo);
            this.Controls.Add(this.btnInsertarEquipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstFutbolistas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEquipos);
            this.Name = "Form1";
            this.pnlInfoCompletaFutbolista.ResumeLayout(false);
            this.pnlInfoCompletaFutbolista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFutbolistas;
        private System.Windows.Forms.Button btnInsertarEquipos;
        private System.Windows.Forms.TextBox txtCodigoEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Button btnInsertarFutbolista;
        private System.Windows.Forms.ComboBox cbEquipoSeleccionado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlInfoCompletaFutbolista;
        private System.Windows.Forms.Button btnModificarFutbolista;
        private System.Windows.Forms.ComboBox cbInfoCompletaEquipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInfoCompletaNombre;
        private System.Windows.Forms.Button btnEliminarFutbolista;
    }
}

