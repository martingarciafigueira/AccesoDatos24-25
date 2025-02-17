using Actividad3.Clases;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        string cadenaConexion;
        public Form1()
        {
            InitializeComponent();
            cadenaConexion = "Initial Catalog=Futbol; Data Source=localhost; user=sa; password=montecastelo";
            lstEquipos.DataSource = GetEquipos();
            cbEquipoSeleccionado.DataSource = GetEquipos();
            cbInfoCompletaEquipo.DataSource = GetEquipos();
        }

        private void lstEquipos_DoubleClick(object sender, EventArgs e)
        {
            Equipo equipoSeleccionado = lstEquipos.SelectedItem as Equipo;
            lstFutbolistas.DataSource = GetFutbolistasByEquipo(equipoSeleccionado).ToList();
        }

        public IEnumerable<Equipo> GetEquipos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return db.GetAll<Equipo>();
            }
        }

        public IEnumerable<Futbolista> GetFutbolistas()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return db.GetAll<Futbolista>();
            }
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipo(Equipo equipo)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return GetFutbolistas().Where(x => x.CodigoEquipo == equipo.Codigo);
            }
        }

        private void btnInsertarEquipos_Click(object sender, EventArgs e)
        {
            Equipo nuevo = new Equipo();
            nuevo.Codigo = txtCodigoEquipo.Text;
            nuevo.Nombre = txtNombreEquipo.Text;
            nuevo.Estadio = txtEstadio.Text;

            InsertarEquipo(nuevo);
            lstEquipos.DataSource = GetEquipos();
            txtCodigoEquipo.Clear();
            txtNombreEquipo.Clear();
            txtEstadio.Clear();
        }

        public void InsertarEquipo(Equipo nuevoEquipo)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Insert(nuevoEquipo);
            }
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista nuevo = new Futbolista();
            nuevo.Codigo = txtCodigoFutbolista.Text;
            nuevo.Nombre = txtNombreFutbolista.Text;
            Equipo equipoSeleccionado = cbEquipoSeleccionado.SelectedValue as Equipo;
            nuevo.CodigoEquipo = equipoSeleccionado.Codigo;

            InsertarFutbolista(nuevo);
            txtCodigoFutbolista.Clear();
            txtNombreFutbolista.Clear();
            cbEquipoSeleccionado.SelectedItem = null;
        }

        public void InsertarFutbolista(Futbolista nuevoFutbolista)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Insert(nuevoFutbolista);
            }
        }

        private void lstFutbolistas_DoubleClick(object sender, EventArgs e)
        {
            pnlInfoCompletaFutbolista.Visible = true;
            Futbolista futbolistaSeleccionado = lstFutbolistas.SelectedItem as Futbolista;

            txtInfoCompletaNombre.Text = futbolistaSeleccionado.Nombre;
            cbInfoCompletaEquipo.SelectedIndex = lstEquipos.SelectedIndex;
        }

        private void btnModificarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolistaSeleccionado = lstFutbolistas.SelectedItem as Futbolista;

            futbolistaSeleccionado.Nombre = txtInfoCompletaNombre.Text;
            Equipo equipoModificado = cbInfoCompletaEquipo.SelectedItem as Equipo;
            futbolistaSeleccionado.CodigoEquipo = equipoModificado.Codigo;

            ModificarFutbolista(futbolistaSeleccionado);
            txtInfoCompletaNombre.Clear();
            cbInfoCompletaEquipo.SelectedItem = null;
            pnlInfoCompletaFutbolista.Visible = false;
        }

        public void ModificarFutbolista(Futbolista futbolistaModificado)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Update(futbolistaModificado);
            }
        }

        private void btnEliminarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolistaSeleccionado = lstFutbolistas.SelectedItem as Futbolista;

            EliminarFutbolista(futbolistaSeleccionado);
            txtInfoCompletaNombre.Clear();
            cbInfoCompletaEquipo.SelectedItem = null;
            pnlInfoCompletaFutbolista.Visible = false;
        }

        public void EliminarFutbolista(Futbolista futbolistaAEliminar)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Delete(futbolistaAEliminar);
            }
        }
    }
}
