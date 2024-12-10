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
        public string ruta;
        public string rutaFichero;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;

            if (isFicheroCreated(rutaFichero))
            {
                insertarInfo();
                mostrarInfo();
            }
            else
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("El fichero no existe, ¿deseas crearlo?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    fichero = crearFichero(rutaFichero);
                    insertarInfo();
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
            fichero = File.OpenText(rutaFichero);
            txtDatosFichero.Text = fichero.ReadToEnd();
            fichero.Close();
        }

        public bool isFicheroCreated(string path)
        {
            return File.Exists(path);
        }

        public void insertarInfo()
        {
            string nombreCompleto = txtNombre.Text + " " + txtApellidos.Text;

            StreamWriter fichero = File.AppendText(rutaFichero);
            fichero.WriteLine(nombreCompleto);
            fichero.Close();
            txtNombre.Clear();
            txtApellidos.Clear();
            mostrarInfo();
        }

        private void btnDefinirRuta_Click(object sender, EventArgs e)
        {
            ruta = txtRutaDirectorio.Text;
            rutaFichero = ruta + @"\" + txtNombreFichero.Text;

            DirectoryInfo di = new DirectoryInfo(ruta);

            if (!di.Exists)
            {
                di.Create();
                MessageBox.Show("Se ha creado la ruta");
            }
            if (!isFicheroCreated(rutaFichero))
            {
                crearFichero(rutaFichero);
            }
        }

        public StreamWriter crearFichero(string ruta)
        {
            StreamWriter fichero = File.CreateText(ruta);
            fichero.Close();
            return fichero;
        }
    }
}
