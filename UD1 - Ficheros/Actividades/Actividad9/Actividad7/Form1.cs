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
            string ruta = @"Alumnos\Nombres.txt";

            if (isFicheroCreated(ruta))
            {
                fichero = File.AppendText(ruta);
                insertarInfo(fichero);
                mostrarInfo();
            }
            else
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("El fichero no existe, ¿deseas crearlo?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    fichero = File.CreateText(ruta);
                    insertarInfo(fichero);
                    mostrarInfo();
                }
            }
            
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

        public bool isFicheroCreated(string path)
        {
            return File.Exists(path);
        }

        public void insertarInfo(StreamWriter fichero)
        {
            string nombreCompleto = txtNombre.Text + " " + txtApellidos.Text;

            fichero.WriteLine(nombreCompleto);
            fichero.Close();
            txtNombre.Clear();
            txtApellidos.Clear();
            mostrarInfo();
        }

    }
}
