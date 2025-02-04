using Actividad3.Clases;
using Dapper;
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
            lstFutbolistas.DataSource = GetFutbolistasByEquipo(equipoSeleccionado);
        }

        public List<Equipo> GetEquipos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Equipos";
                List<Equipo> listaEquipos = (List<Equipo>)db.Query<Equipo>(consulta);
                return listaEquipos;
            }
        }

        public List<Futbolista> GetFutbolistasByEquipo(Equipo equipo)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"SELECT F.* FROM Futbolistas F INNER JOIN Equipos E ON f.CodigoEquipo = e.Codigo WHERE E.codigo = '{equipo.Codigo}'";
                List<Futbolista> listaFutbolistas = (List<Futbolista>)db.Query<Futbolista>(consulta);
                return listaFutbolistas;
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
            var consulta = $@"INSERT INTO Equipos (Codigo, Nombre, Estadio) VALUES (@Codigo, @Nombre, @Estadio)";

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Execute(consulta, nuevoEquipo);
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
            var consulta = $@"INSERT INTO Futbolistas(Codigo, Nombre, CodigoEquipo) VALUES (@Codigo, @Nombre, @CodigoEquipo)";

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Execute(consulta, nuevoFutbolista);
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
            var consulta = $@"UPDATE Futbolistas SET Nombre = @Nombre, CodigoEquipo = @CodigoEquipo WHERE Codigo = @Codigo";

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Execute(consulta, futbolistaModificado);
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
            var consulta = $@"DELETE FROM Futbolistas WHERE Codigo = @Codigo";

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Execute(consulta, futbolistaAEliminar);
            }
        }
    }
}
