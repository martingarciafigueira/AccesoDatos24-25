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
    public partial class ListFormInstituto : Form
    {
        public ListFormInstituto()
        {
            InitializeComponent();
            configurarDataGridView();
            cargarListInstitutos();
        }

        private InstitutoService institutoService = new InstitutoService();

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

            this.tblInstitutos.Columns.Add("id", "ID Instituto");
            this.tblInstitutos.Columns.Add("name", "Nombre Instituto");
            this.tblInstitutos.Columns.Add("description", "Descripción");
            this.tblInstitutos.Columns.Add(columnActualizar);
            this.tblInstitutos.Columns.Add(columnEliminar);
        }

        private void cargarListInstitutos()
        {
            this.tblInstitutos.Rows.Clear();
            List<Instituto> listaInstitutos = this.institutoService.GetAll();

            foreach (Instituto instituto in listaInstitutos)
            {
                this.tblInstitutos.Rows.Add(instituto.IdInstituto, instituto.NombreInstituto, instituto.DescripcionInstituto);
            }
        }

        private void eliminarInstituto(int id)
        {
            Instituto _instituto = this.institutoService.GetById(id);
            this.institutoService.Delete(_instituto);
            this.cargarListInstitutos();
        }

        private void actualizarInstituto(int id)
        {
            Instituto _instituto = this.institutoService.GetById(id);
            this.cargarFormInstituto(_instituto);
        }

        private void tblInstitutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblInstitutos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Quieres eliminar el instituto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)tblInstitutos.Rows[e.RowIndex].Cells["id"].Value;
                    this.eliminarInstituto(id);
                }
            }
            else if (tblInstitutos.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                int id = (int)tblInstitutos.Rows[e.RowIndex].Cells["id"].Value;
                this.actualizarInstituto(id);
            }
        }

        private void cargarFormInstituto(Instituto unInstituto)
        {
            FormInstituto viewForm = new FormInstituto(unInstituto);
            viewForm.Show();
        }

        private void btnNuevoInstituto_Click(object sender, EventArgs e)
        {
            this.cargarFormInstituto(null);
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            this.cargarListInstitutos();
        }

        private void btnVerTodosInstitutos_Click(object sender, EventArgs e)
        {

        }
    }
}
