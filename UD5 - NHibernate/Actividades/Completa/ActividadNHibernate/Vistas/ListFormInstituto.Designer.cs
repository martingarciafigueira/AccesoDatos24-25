namespace ActividadNHibernate.Vistas
{
    partial class ListFormInstituto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblInstitutos = new System.Windows.Forms.DataGridView();
            this.btnNuevoInstituto = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnVerTodosInstitutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblInstitutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de institutos";
            // 
            // tblInstitutos
            // 
            this.tblInstitutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInstitutos.Location = new System.Drawing.Point(37, 176);
            this.tblInstitutos.Margin = new System.Windows.Forms.Padding(4);
            this.tblInstitutos.Name = "tblInstitutos";
            this.tblInstitutos.RowHeadersWidth = 51;
            this.tblInstitutos.Size = new System.Drawing.Size(1223, 415);
            this.tblInstitutos.TabIndex = 1;
            this.tblInstitutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblInstitutos_CellContentClick);
            // 
            // btnNuevoInstituto
            // 
            this.btnNuevoInstituto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInstituto.Location = new System.Drawing.Point(847, 41);
            this.btnNuevoInstituto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoInstituto.Name = "btnNuevoInstituto";
            this.btnNuevoInstituto.Size = new System.Drawing.Size(204, 36);
            this.btnNuevoInstituto.TabIndex = 2;
            this.btnNuevoInstituto.Text = "Nuevo instituto";
            this.btnNuevoInstituto.UseVisualStyleBackColor = true;
            this.btnNuevoInstituto.Click += new System.EventHandler(this.btnNuevoInstituto_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.Location = new System.Drawing.Point(1056, 41);
            this.btnActualizarTabla.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(204, 36);
            this.btnActualizarTabla.TabIndex = 3;
            this.btnActualizarTabla.Text = "Actualizar tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnVerTodosInstitutos
            // 
            this.btnVerTodosInstitutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodosInstitutos.Location = new System.Drawing.Point(37, 110);
            this.btnVerTodosInstitutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodosInstitutos.Name = "btnVerTodosInstitutos";
            this.btnVerTodosInstitutos.Size = new System.Drawing.Size(204, 36);
            this.btnVerTodosInstitutos.TabIndex = 4;
            this.btnVerTodosInstitutos.Text = "Ver todos";
            this.btnVerTodosInstitutos.UseVisualStyleBackColor = true;
            this.btnVerTodosInstitutos.Click += new System.EventHandler(this.btnVerTodosInstitutos_Click);
            // 
            // ListFormInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 606);
            this.Controls.Add(this.btnVerTodosInstitutos);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnNuevoInstituto);
            this.Controls.Add(this.tblInstitutos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListFormInstituto";
            this.Text = "ListFormInstituto";
            ((System.ComponentModel.ISupportInitialize)(this.tblInstitutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblInstitutos;
        private System.Windows.Forms.Button btnNuevoInstituto;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnVerTodosInstitutos;
    }
}