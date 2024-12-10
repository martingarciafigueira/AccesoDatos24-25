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
            string nombreCompleto = txtNombre.Text + " " + txtApellidos.Text;
            
            fichero = File.AppendText(@"Alumnos\Nombres.txt");
            fichero.WriteLine(nombreCompleto);
            fichero.Close();
            txtNombre.Clear();
            txtApellidos.Clear();
            mostrarInfo();
        }

        private void btnMostrarInfoFichero_Click(object sender, EventArgs e)
        {
            mostrarInfo();
        }

        public void mostrarInfo()
        {
            StreamReader fichero;
            fichero = File.OpenText(@"Alumnos\Nombres.txt");
            txtDatosFichero.Text = fichero.ReadToEnd();
            fichero.Close();
        }
    }
}
