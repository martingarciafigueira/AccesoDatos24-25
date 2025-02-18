namespace ActividadNHibernate.Vistas
{
    partial class ListFormAsignatura
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
            this.tblAsignaturas = new System.Windows.Forms.DataGridView();
            this.btnNuevaAsignatura = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnVerTodasAsignaturas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de asignaturas";
            // 
            // tblAsignaturas
            // 
            this.tblAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAsignaturas.Location = new System.Drawing.Point(37, 176);
            this.tblAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.tblAsignaturas.Name = "tblAsignaturas";
            this.tblAsignaturas.RowHeadersWidth = 51;
            this.tblAsignaturas.Size = new System.Drawing.Size(1223, 415);
            this.tblAsignaturas.TabIndex = 1;
            this.tblAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblInstitutos_CellContentClick);
            // 
            // btnNuevaAsignatura
            // 
            this.btnNuevaAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAsignatura.Location = new System.Drawing.Point(844, 26);
            this.btnNuevaAsignatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaAsignatura.Name = "btnNuevaAsignatura";
            this.btnNuevaAsignatura.Size = new System.Drawing.Size(204, 70);
            this.btnNuevaAsignatura.TabIndex = 2;
            this.btnNuevaAsignatura.Text = "Nueva asignatura";
            this.btnNuevaAsignatura.UseVisualStyleBackColor = true;
            this.btnNuevaAsignatura.Click += new System.EventHandler(this.btnNuevoInstituto_Click);
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
            // btnVerTodasAsignaturas
            // 
            this.btnVerTodasAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodasAsignaturas.Location = new System.Drawing.Point(37, 110);
            this.btnVerTodasAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodasAsignaturas.Name = "btnVerTodasAsignaturas";
            this.btnVerTodasAsignaturas.Size = new System.Drawing.Size(204, 36);
            this.btnVerTodasAsignaturas.TabIndex = 4;
            this.btnVerTodasAsignaturas.Text = "Ver todos";
            this.btnVerTodasAsignaturas.UseVisualStyleBackColor = true;
            this.btnVerTodasAsignaturas.Click += new System.EventHandler(this.btnVerTodasAsignaturas_Click);
            // 
            // ListFormAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 606);
            this.Controls.Add(this.btnVerTodasAsignaturas);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnNuevaAsignatura);
            this.Controls.Add(this.tblAsignaturas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListFormAsignatura";
            this.Text = "ListFormInstituto";
            ((System.ComponentModel.ISupportInitialize)(this.tblAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblAsignaturas;
        private System.Windows.Forms.Button btnNuevaAsignatura;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnVerTodasAsignaturas;
    }
}