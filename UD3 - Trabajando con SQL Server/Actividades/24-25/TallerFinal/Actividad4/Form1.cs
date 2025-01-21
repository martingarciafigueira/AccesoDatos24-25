using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Actividad4.Properties.Settings.FutbolConnectionString"].ConnectionString);
            conexion.Open();
        }

        private void btnMostrarFutbolistas_Click(object sender, EventArgs e)
        {
            mostrarFutbolistas();
        }

        private void btnMostrarEquipos_Click(object sender, EventArgs e)
        {
            mostrarEquipos();
        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Equipos (Codigo, Nombre, Estadio) VALUES (@CodigoEquipo, @NombreEquipo, @Estadio)";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@CodigoEquipo", txtCodigoEquipo.Text);
            comando.Parameters.AddWithValue("@NombreEquipo", txtNombreEquipo.Text);
            comando.Parameters.AddWithValue("@Estadio", txtEstadio.Text);

            comando.ExecuteNonQuery();

            txtCodigoEquipo.Clear();
            txtNombreEquipo.Clear();
            txtEstadio.Clear();
            mostrarEquipos();
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Futbolistas (Codigo, Nombre, CodigoEquipo) VALUES (@CodigoFutbolista, @NombreFutbolista, @CodigoEquipoFutbolista)";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@CodigoFutbolista", txtCodigoFutbolista.Text);
            comando.Parameters.AddWithValue("@NombreFutbolista", txtNombreFutbolista.Text);
            comando.Parameters.AddWithValue("@CodigoEquipoFutbolista", txtEquipoFutbolista.Text);

            comando.ExecuteNonQuery();

            txtCodigoFutbolista.Clear();
            txtNombreFutbolista.Clear();
            txtEquipoFutbolista.Clear();
            mostrarFutbolistas();
        }

        private void btnBorrarFutbolista_Click(object sender, EventArgs e)
        {
            if (lstFutbolistas.SelectedValue != null)
            {
                string idFutbolistaABorrar = lstFutbolistas.SelectedValue.ToString();
                string consulta = "DELETE FROM Futbolistas WHERE Codigo = @CodigoFutbolista";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@CodigoFutbolista", idFutbolistaABorrar);

                comando.ExecuteNonQuery();

                MessageBox.Show("El futbolista se ha borrado");
                mostrarFutbolistas();
            }
            else
            {
                MessageBox.Show("Selecciona un tío");
            }
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            if (lstEquipos.SelectedValue != null)
            {
                string idEquipoABorrar = lstEquipos.SelectedValue.ToString();
                string consulta = "DELETE FROM Equipos WHERE Codigo = @CodigoEquipo";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@CodigoEquipo", idEquipoABorrar);

                comando.ExecuteNonQuery();

                MessageBox.Show("El equipo se ha borrado");
                mostrarEquipos();
                mostrarFutbolistas();
            }
            else
            {
                MessageBox.Show("Selecciona un team");
            }
        }

        public void mostrarFutbolistas()
        {
            string consulta = "SELECT Codigo, Nombre FROM futbolistas";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

            using (adapter)
            {
                DataTable futbolistas = new DataTable();
                adapter.Fill(futbolistas);

                lstFutbolistas.ValueMember = "Codigo";
                lstFutbolistas.DisplayMember = "Nombre";
                lstFutbolistas.DataSource = futbolistas;
            }
        }

        public void mostrarEquipos()
        {
            string consulta = "SELECT Codigo, Nombre FROM Equipos";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

            using (adapter)
            {
                DataTable equipos = new DataTable();
                adapter.Fill(equipos);

                lstEquipos.ValueMember = "Codigo";
                lstEquipos.DisplayMember = "Nombre";
                lstEquipos.DataSource = equipos;
            }
        }
    }
}
