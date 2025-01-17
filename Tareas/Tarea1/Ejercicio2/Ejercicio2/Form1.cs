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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            // Abrimos el menú de selección de ficheros
            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                string rutaFichero = openFileDialog.FileName;

                // Abrir el fichero
                var fileStream = openFileDialog.OpenFile();

                // Leer el fichero
                StreamReader reader = new StreamReader(fileStream);
                string data = reader.ReadToEnd();              
                reader.Close();

                // Obtener nombre fichero origen
                FileInfo fi = new FileInfo(openFileDialog.FileName);

                // Seleccionar donde se guarda la copia
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = (fi.Name.Split('.'))[0] + "_Copia";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.ShowDialog();

                // Creación de la copia
                StreamWriter fichero = File.CreateText(saveFileDialog.FileName);

                for(int i = 0; i < data.Length; i++)
                {
                    fichero.Write(data.Substring(i, 1));
                }
                fichero.Close();
                MessageBox.Show("Copia creada correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
