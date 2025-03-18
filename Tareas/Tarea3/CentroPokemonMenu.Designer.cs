namespace Tarea03Pokemon
{
    partial class CentroPokemonMenu
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
            this.btCombate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAtaques = new System.Windows.Forms.ListBox();
            this.lbPokemonEvolucionesPrevias = new System.Windows.Forms.ListBox();
            this.lbPokemonEvolucionesAltas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPokemons = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCombate
            // 
            this.btCombate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btCombate.Location = new System.Drawing.Point(289, 503);
            this.btCombate.Name = "btCombate";
            this.btCombate.Size = new System.Drawing.Size(323, 74);
            this.btCombate.TabIndex = 7;
            this.btCombate.Text = "Combate";
            this.btCombate.UseVisualStyleBackColor = false;
            this.btCombate.Click += new System.EventHandler(this.btCombate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbAtaques);
            this.groupBox1.Controls.Add(this.lbPokemonEvolucionesPrevias);
            this.groupBox1.Controls.Add(this.lbPokemonEvolucionesAltas);
            this.groupBox1.Location = new System.Drawing.Point(585, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 485);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pokemon Seleccionado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ataques";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Evoluciones Anteriores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Evoluciones Siguientes";
            // 
            // lbAtaques
            // 
            this.lbAtaques.FormattingEnabled = true;
            this.lbAtaques.Location = new System.Drawing.Point(24, 229);
            this.lbAtaques.Name = "lbAtaques";
            this.lbAtaques.Size = new System.Drawing.Size(222, 238);
            this.lbAtaques.TabIndex = 18;
            // 
            // lbPokemonEvolucionesPrevias
            // 
            this.lbPokemonEvolucionesPrevias.FormattingEnabled = true;
            this.lbPokemonEvolucionesPrevias.Location = new System.Drawing.Point(24, 134);
            this.lbPokemonEvolucionesPrevias.Name = "lbPokemonEvolucionesPrevias";
            this.lbPokemonEvolucionesPrevias.Size = new System.Drawing.Size(222, 69);
            this.lbPokemonEvolucionesPrevias.TabIndex = 17;
            // 
            // lbPokemonEvolucionesAltas
            // 
            this.lbPokemonEvolucionesAltas.FormattingEnabled = true;
            this.lbPokemonEvolucionesAltas.Location = new System.Drawing.Point(22, 36);
            this.lbPokemonEvolucionesAltas.Name = "lbPokemonEvolucionesAltas";
            this.lbPokemonEvolucionesAltas.Size = new System.Drawing.Size(224, 69);
            this.lbPokemonEvolucionesAltas.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbTipo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbPokemons);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbAltura);
            this.groupBox2.Controls.Add(this.tbPeso);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 485);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(15, 33);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 21;
            this.cbTipo.TextChanged += new System.EventHandler(this.cbTipo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lista Pokemon";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPokemons
            // 
            this.lbPokemons.FormattingEnabled = true;
            this.lbPokemons.Location = new System.Drawing.Point(238, 36);
            this.lbPokemons.Name = "lbPokemons";
            this.lbPokemons.Size = new System.Drawing.Size(296, 433);
            this.lbPokemons.TabIndex = 19;
            this.lbPokemons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPokemons_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo";
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(15, 114);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(121, 20);
            this.tbAltura.TabIndex = 15;
            this.tbAltura.TextChanged += new System.EventHandler(this.tbAltura_TextChanged);
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(15, 73);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(121, 20);
            this.tbPeso.TabIndex = 14;
            this.tbPeso.TextChanged += new System.EventHandler(this.tbPeso_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filtra en automatico según ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "se completan los campos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "DobleClick sobre un pokemon para ver";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "sus Evoluciones y Ataques";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Formulario COMBATE ->>>>>";
            // 
            // CentroPokemonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 589);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCombate);
            this.Name = "CentroPokemonMenu";
            this.Text = "Centro Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCombate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lbAtaques;
        public System.Windows.Forms.ListBox lbPokemonEvolucionesPrevias;
        public System.Windows.Forms.ListBox lbPokemonEvolucionesAltas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox lbPokemons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

