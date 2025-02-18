namespace ActividadNHibernate.Vistas
{
    partial class ListFormEstudiante
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
            this.btnNuevoEstudiante = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnVerTodosEstudiantes = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de estudiantes";
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
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(844, 26);
            this.btnNuevoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(204, 70);
            this.btnNuevoEstudiante.TabIndex = 2;
            this.btnNuevoEstudiante.Text = "Nuevo estudiante";
            this.btnNuevoEstudiante.UseVisualStyleBackColor = true;
            this.btnNuevoEstudiante.Click += new System.EventHandler(this.btnNuevoEstudiante_Click_1);
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
            // btnVerTodosEstudiantes
            // 
            this.btnVerTodosEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodosEstudiantes.Location = new System.Drawing.Point(37, 110);
            this.btnVerTodosEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTodosEstudiantes.Name = "btnVerTodosEstudiantes";
            this.btnVerTodosEstudiantes.Size = new System.Drawing.Size(204, 36);
            this.btnVerTodosEstudiantes.TabIndex = 4;
            this.btnVerTodosEstudiantes.Text = "Ver todos";
            this.btnVerTodosEstudiantes.UseVisualStyleBackColor = true;
            // 
            // ListFormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 606);
            this.Controls.Add(this.btnVerTodosEstudiantes);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnNuevoEstudiante);
            this.Controls.Add(this.tblInstitutos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListFormEstudiante";
            this.Text = "ListFormInstituto";
            ((System.ComponentModel.ISupportInitialize)(this.tblInstitutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblInstitutos;
        private System.Windows.Forms.Button btnNuevoEstudiante;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnVerTodosEstudiantes;
    }
}