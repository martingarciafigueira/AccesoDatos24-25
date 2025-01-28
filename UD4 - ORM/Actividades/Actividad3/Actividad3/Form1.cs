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
        }

        public void ConsultarEquipos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Equipos";
                List<Equipo> listaEquipos = (List<Equipo>) db.Query<Equipo>(consulta);
                lstEquipos.DataSource = listaEquipos;
            }
        }

        private void btnObtenerEquipos_Click(object sender, EventArgs e)
        {
            ConsultarEquipos();
        }
    }
}
