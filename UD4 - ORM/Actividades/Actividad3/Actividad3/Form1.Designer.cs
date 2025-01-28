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
            this.btnObtenerEquipos = new System.Windows.Forms.Button();
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnObtenerEquipos
            // 
            this.btnObtenerEquipos.Location = new System.Drawing.Point(129, 256);
            this.btnObtenerEquipos.Name = "btnObtenerEquipos";
            this.btnObtenerEquipos.Size = new System.Drawing.Size(234, 120);
            this.btnObtenerEquipos.TabIndex = 0;
            this.btnObtenerEquipos.Text = "Obtener equipos";
            this.btnObtenerEquipos.UseVisualStyleBackColor = true;
            this.btnObtenerEquipos.Click += new System.EventHandler(this.btnObtenerEquipos_Click);
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(686, 185);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(300, 308);
            this.lstEquipos.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1212, 651);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.btnObtenerEquipos);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerEquipos;
        private System.Windows.Forms.ListBox lstEquipos;
    }
}

