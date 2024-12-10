using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;

            fichero = File.AppendText("log.txt");
            fichero.WriteLine(txtDatosInsertados.Text);
            fichero.Close();
            txtDatosInsertados.Clear();
        }

        private void btnMostrarInfoFichero_Click(object sender, EventArgs e)
        {
            StreamReader fichero;

            fichero = File.OpenText("log.txt");

            txtDatosFichero.Text = fichero.ReadToEnd();

            fichero.Close();
        }
    }
}
