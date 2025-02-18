using ActividadNHibernate.Entidades;
using ActividadNHibernate.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadNHibernate.Vistas
{
    public partial class ListFormEstudiante : Form
    {
        public ListFormEstudiante()
        {
            InitializeComponent();
            configurarDataGridView();
            cargarListestudiantes();
        }

        private EstudianteService estudianteService = new EstudianteService();

        private void configurarDataGridView()
        {
            DataGridViewButtonColumn columnActualizar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn columnEliminar = new DataGridViewButtonColumn();

            columnActualizar.HeaderText = "Actualizar";
            columnActualizar.Name = "Actualizar";
            columnActualizar.Text = "Actualizar";
            columnActualizar.UseColumnTextForButtonValue = true;

            columnEliminar.HeaderText = "Eliminar";
            columnEliminar.Name = "Eliminar";
            columnEliminar.Text = "Eliminar";
            columnEliminar.UseColumnTextForButtonValue = true;

            this.tblInstitutos.Columns.Add("id", "ID estudiante");
            this.tblInstitutos.Columns.Add("name", "Nombre estudiante");
            this.tblInstitutos.Columns.Add("apellido", "Apellido estudiante");
            this.tblInstitutos.Columns.Add("description", "Descripción");
            this.tblInstitutos.Columns.Add(columnActualizar);
            this.tblInstitutos.Columns.Add(columnEliminar);
        }

        private void cargarListestudiantes()
        {
            this.tblInstitutos.Rows.Clear();
            List<Estudiante> listaestudiantes = this.estudianteService.GetAll();

            foreach (Estudiante estudiante in listaestudiantes)
            {
                this.tblInstitutos.Rows.Add(estudiante.IdEstudiante, estudiante.NombreEstudiante,estudiante.ApellidoEstudiante, estudiante.DocumentoEstudiante);
            }
        }

        private void eliminarestudiante(int id)
        {
            Estudiante _estudiante = this.estudianteService.GetById(id);
            this.estudianteService.Delete(_estudiante);
            this.cargarListestudiantes();
        }

        private void actualizarestudiante(int id)
        {
            Estudiante _estudiante = this.estudianteService.GetById(id);
            this.cargarFormestudiante(_estudiante);
        }

        private void tblestudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblInstitutos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Quieres eliminar el estudiante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)tblInstitutos.Rows[e.RowIndex].Cells["id"].Value;
                    this.eliminarestudiante(id);
                }
            }
            else if (tblInstitutos.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                int id = (int)tblInstitutos.Rows[e.RowIndex].Cells["id"].Value;
                this.actualizarestudiante(id);
            }
        }

        private void cargarFormestudiante(Estudiante unestudiante)
        {
            FormEstudiante viewForm = new FormEstudiante(unestudiante);
            viewForm.Show();
        }

        private void btnNuevoestudiante_Click(object sender, EventArgs e)
        {
            this.cargarFormestudiante(null);
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            this.cargarListestudiantes();
        }

        private void btnVerTodosestudiantes_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoEstudiante_Click_1(object sender, EventArgs e)
        {
            this.cargarFormestudiante(null);
        }
    }
}
