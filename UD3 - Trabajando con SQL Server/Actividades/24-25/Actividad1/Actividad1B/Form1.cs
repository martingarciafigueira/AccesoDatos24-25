using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace Actividad1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conexion =
            new SqlConnection("server=localhost; database=Futbol; integrated security = true; TrustServerCertificate = true");

            conexion.Open();
            MessageBox.Show("La conexion se ha realizado correctamente");
            conexion.Close();
        }
    }
}
