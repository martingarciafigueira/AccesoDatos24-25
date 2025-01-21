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
            panelVisualizacion.Visible = false;

        }
    }
}
