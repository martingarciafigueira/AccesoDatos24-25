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

namespace Actividad11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Métodos privados

        private void btnCrearDirectorio_Click(object sender, EventArgs e)
        {
            if (CrearDirectorio(txtRutaDirectorio.Text)) MessageBox.Show("Directorio creado correctamente");
            else MessageBox.Show("El directorio ya existe");
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            if (CrearArchivo(txtRutaDirectorio2.Text, txtNombreFichero.Text, txtContenido.Text)) MessageBox.Show("Archivo creado correctamente con el contenido");
            else MessageBox.Show("El archivo ya existe");
        }

        private void btnMoverACarpeta_Click(object sender, EventArgs e)
        {
            if (MoverArchivo(txtFicheroOrigen.Text, txtCarpetaDestino.Text)) MessageBox.Show("Archivo movido correctamente");
            else MessageBox.Show("Ha fallado el mover el archivo");
        }

        private void btnListarDirectorio_Click(object sender, EventArgs e)
        {
            ListarDirectorio(txtRutaDirectorio3.Text);
        }

        //Métodos públicos

        public bool CrearDirectorio(string rutaDirectorio)
        {
            DirectoryInfo di = new DirectoryInfo(rutaDirectorio);

            if (!di.Exists)
            {
                di.Create();
                return true;
            }
            return false;   
        }

        public bool CrearArchivo(string rutaDirectorio, string nombreFichero, string contenido = "")
        {
            StreamWriter fichero;

            CrearDirectorio(rutaDirectorio);

            string rutaFichero = rutaDirectorio + @"\" + nombreFichero;

            if (File.Exists(rutaFichero))
            {
                return false;
            }
            fichero = File.CreateText(rutaFichero);
            fichero.WriteLine(contenido);
            fichero.Close();
            return true;
        }

        public bool MoverArchivo(string rutaOrigen, string rutaDestino)
        {
            string nombreFichero, rutaFicheroDestino;
            try
            {
                nombreFichero = Path.GetFileName(rutaOrigen);

                rutaFicheroDestino = rutaDestino + @"\" + nombreFichero;

                Directory.Move(rutaOrigen, rutaFicheroDestino);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ListarDirectorio(string rutaDirectorio)
        {
            DirectoryInfo di = new DirectoryInfo(rutaDirectorio);
            string[] nombreArchivos;
            string nombreFichero;

            if (di.Exists)
            {
                nombreArchivos = Directory.GetFiles(rutaDirectorio);

                lstContenidoDirectorio.Items.Clear();

                //Con ruta de acceso
                //lstContenidoDirectorio.Items.AddRange(nombreArchivos);

                //Sólo nombre de fichero
                foreach (string FicheroConRutaDeAcceso in nombreArchivos)
                {
                    nombreFichero = Path.GetFileName(FicheroConRutaDeAcceso);

                    lstContenidoDirectorio.Items.Add(nombreFichero);
                }
                return true;
            }
            return false;
        }

    }
}
