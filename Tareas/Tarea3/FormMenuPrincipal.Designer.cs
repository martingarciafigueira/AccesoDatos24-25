namespace Tarea03Pokemon
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCentroPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCentroPokemon
            // 
            this.btCentroPokemon.Location = new System.Drawing.Point(103, 147);
            this.btCentroPokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCentroPokemon.Name = "btCentroPokemon";
            this.btCentroPokemon.Size = new System.Drawing.Size(848, 214);
            this.btCentroPokemon.TabIndex = 1;
            this.btCentroPokemon.Text = "Centro Pokemon";
            this.btCentroPokemon.UseVisualStyleBackColor = true;
            this.btCentroPokemon.Click += new System.EventHandler(this.btCentroPokemon_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btCentroPokemon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenuPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCentroPokemon;
    }
}