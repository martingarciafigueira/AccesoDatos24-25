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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion =
            //new SqlConnection("server=localhost; database=Futbol; integrated security = true; TrustServerCertificate = true");

            SqlConnection conexion =
            new SqlConnection(ConfigurationManager.ConnectionStrings["Actividad4.Properties.Settings.tiendaConnectionString"].ConnectionString);

            conexion.Open();
            MessageBox.Show("La conexion se ha realizado correctamente");
            conexion.Close();
        }
    }
}
