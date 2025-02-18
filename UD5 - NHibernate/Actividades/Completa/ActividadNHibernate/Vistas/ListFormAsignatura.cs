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
    public partial class ListFormAsignatura : Form
    {
        public ListFormAsignatura()
        {
            InitializeComponent();
            configurarDataGridView();
            cargarListAsignaturas();
        }

        private AsignaturaService asignaturaService = new AsignaturaService();

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

            this.tblAsignaturas.Columns.Add("id", "ID Asignatura");
            this.tblAsignaturas.Columns.Add("name", "Nombre Asignatura");
            this.tblAsignaturas.Columns.Add("description", "Descripción");
            this.tblAsignaturas.Columns.Add(columnActualizar);
            this.tblAsignaturas.Columns.Add(columnEliminar);
        }

        private void cargarListAsignaturas()
        {
            this.tblAsignaturas.Rows.Clear();
            List<Asignatura> listaAsignaturas = this.asignaturaService.GetAll();

            foreach (Asignatura asignatura in listaAsignaturas)
            {
                this.tblAsignaturas.Rows.Add(asignatura.IdAsignatura, asignatura.NombreAsignatura, asignatura.DescripcionAsignatura);
            }
        }

        private void eliminarAsignatura(int id)
        {
            Asignatura asignatura = this.asignaturaService.GetById(id);
            this.asignaturaService.Delete(asignatura);
            this.cargarListAsignaturas();
        }

        private void actualizarAsignatura(int id)
        {
            Asignatura asignatura = this.asignaturaService.GetById(id);
            this.cargarFormAsignatura(asignatura);
        }

        private void tblInstitutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblAsignaturas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Quieres eliminar la asignatura?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)tblAsignaturas.Rows[e.RowIndex].Cells["id"].Value;
                    this.eliminarAsignatura(id);
                }
            }
            else if (tblAsignaturas.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                int id = (int)tblAsignaturas.Rows[e.RowIndex].Cells["id"].Value;
                this.actualizarAsignatura(id);
            }
        }

        private void cargarFormAsignatura(Asignatura unaAsignatura)
        {
            FormAsignatura viewForm = new FormAsignatura(unaAsignatura);
            viewForm.Show();
        }

        private void btnNuevoInstituto_Click(object sender, EventArgs e)
        {
            this.cargarFormAsignatura(null);
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            this.cargarListAsignaturas();
        }

        private void btnVerTodasAsignaturas_Click(object sender, EventArgs e)
        {

        }
    }
}
