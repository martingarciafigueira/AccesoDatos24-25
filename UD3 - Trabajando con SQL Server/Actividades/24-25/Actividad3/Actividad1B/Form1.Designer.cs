namespace Actividad1B
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombrePersonaje = new TextBox();
            txtPoderPersonaje = new TextBox();
            label4 = new Label();
            txtNacionalidadPersonaje = new TextBox();
            label5 = new Label();
            btnInsertarPersonaje = new Button();
            txtInfoPersonajes = new TextBox();
            btnVerPersonajes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 188);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 1;
            label1.Text = "ZONA NUEVO PERSONAJE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(690, 188);
            label2.Name = "label2";
            label2.Size = new Size(193, 31);
            label2.TabIndex = 2;
            label2.Text = "VER PERSONAJES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 283);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombrePersonaje
            // 
            txtNombrePersonaje.Location = new Point(250, 283);
            txtNombrePersonaje.Name = "txtNombrePersonaje";
            txtNombrePersonaje.Size = new Size(125, 27);
            txtNombrePersonaje.TabIndex = 4;
            // 
            // txtPoderPersonaje
            // 
            txtPoderPersonaje.Location = new Point(250, 328);
            txtPoderPersonaje.Name = "txtPoderPersonaje";
            txtPoderPersonaje.Size = new Size(125, 27);
            txtPoderPersonaje.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 328);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 5;
            label4.Text = "Poder";
            // 
            // txtNacionalidadPersonaje
            // 
            txtNacionalidadPersonaje.Location = new Point(250, 378);
            txtNacionalidadPersonaje.Name = "txtNacionalidadPersonaje";
            txtNacionalidadPersonaje.Size = new Size(125, 27);
            txtNacionalidadPersonaje.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 378);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 7;
            label5.Text = "Nacionalidad";
            // 
            // btnInsertarPersonaje
            // 
            btnInsertarPersonaje.Location = new Point(145, 453);
            btnInsertarPersonaje.Name = "btnInsertarPersonaje";
            btnInsertarPersonaje.Size = new Size(147, 69);
            btnInsertarPersonaje.TabIndex = 9;
            btnInsertarPersonaje.Text = "Insertar";
            btnInsertarPersonaje.UseVisualStyleBackColor = true;
            btnInsertarPersonaje.Click += btnInsertarPersonaje_Click;
            // 
            // txtInfoPersonajes
            // 
            txtInfoPersonajes.Location = new Point(617, 268);
            txtInfoPersonajes.Multiline = true;
            txtInfoPersonajes.Name = "txtInfoPersonajes";
            txtInfoPersonajes.ReadOnly = true;
            txtInfoPersonajes.Size = new Size(343, 137);
            txtInfoPersonajes.TabIndex = 10;
            // 
            // btnVerPersonajes
            // 
            btnVerPersonajes.Location = new Point(711, 453);
            btnVerPersonajes.Name = "btnVerPersonajes";
            btnVerPersonajes.Size = new Size(147, 69);
            btnVerPersonajes.TabIndex = 11;
            btnVerPersonajes.Text = "Mostrar";
            btnVerPersonajes.UseVisualStyleBackColor = true;
            btnVerPersonajes.Click += btnVerPersonajes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 656);
            Controls.Add(btnVerPersonajes);
            Controls.Add(txtInfoPersonajes);
            Controls.Add(btnInsertarPersonaje);
            Controls.Add(txtNacionalidadPersonaje);
            Controls.Add(label5);
            Controls.Add(txtPoderPersonaje);
            Controls.Add(label4);
            Controls.Add(txtNombrePersonaje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombrePersonaje;
        private TextBox txtPoderPersonaje;
        private Label label4;
        private TextBox txtNacionalidadPersonaje;
        private Label label5;
        private Button btnInsertarPersonaje;
        private TextBox txtInfoPersonajes;
        private Button btnVerPersonajes;
    }
}
