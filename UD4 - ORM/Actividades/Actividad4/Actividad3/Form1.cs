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
            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Estadio = txtEstadio.Text;

            InsertarEquipo(nuevo);
            lstEquipos.DataSource = GetEquipos();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtEstadio.Clear();
        }

        public void InsertarEquipo(Equipo nuevo)
        {
            var consulta = $@"INSERT INTO Equipos (Codigo, Nombre, Estadio) VALUES ('{nuevo.Codigo}', '{nuevo.Nombre}', '{nuevo.Estadio}')";

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                db.Execute(new CommandDefinition(consulta));
            }
        }
    }
}
