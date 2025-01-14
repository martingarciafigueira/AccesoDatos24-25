using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Actividad1B
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection("server=localhost; database=DragonBallZ; integrated security = true; TrustServerCertificate = true");
            conexion.Open();
        }

        private void btnInsertarPersonaje_Click(object sender, EventArgs e)
        {
            string nombre, nacionalidad, consulta;
            int poder;

            nombre = txtNombrePersonaje.Text;
            nacionalidad = txtNacionalidadPersonaje.Text;
            int.TryParse(txtPoderPersonaje.Text, out poder);

            consulta = "INSERT INTO Personajes VALUES(@Nombre, @Poder, @Nacionalidad)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Poder", poder);
            comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);

            int registros = comando.ExecuteNonQuery();

            if (registros == 1)
            {
                MessageBox.Show("Se ha insertado correctamente el personaje");
                txtNombrePersonaje.Clear();
                txtPoderPersonaje.Clear();
                txtNacionalidadPersonaje.Clear();
            }
            else
            {
                MessageBox.Show("Algo salió mal...");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.Close();
        }

        private void btnVerPersonajes_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre, poder, Nacionalidad FROM Personajes";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            txtInfoPersonajes.Clear();

            while (registros.Read())
            {
                txtInfoPersonajes.AppendText(registros["nombre"].ToString());
                txtInfoPersonajes.AppendText(" - ");
                txtInfoPersonajes.AppendText(registros["poder"].ToString());
                txtInfoPersonajes.AppendText(" - ");
                txtInfoPersonajes.AppendText(registros["nacionalidad"].ToString());
                txtInfoPersonajes.AppendText(Environment.NewLine);
            }

            registros.Close();
        }
    }
}
