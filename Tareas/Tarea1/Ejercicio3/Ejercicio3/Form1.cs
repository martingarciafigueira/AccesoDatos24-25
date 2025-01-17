using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // Abrimos el menú de selección de ficheros
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaFichero = openFileDialog.FileName;

                // Abrir el fichero
                var fileStream = openFileDialog.OpenFile();

                // Leer el fichero
                StreamReader reader = new StreamReader(fileStream);
                List<string> lista = reader.ReadToEnd().Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                reader.Close();

                // Recorremos los datos
                string strPath = "";

                foreach (string texto in lista)
                {
                    if (Regex.IsMatch(texto, @"^[A-Z|a-z]:/"))
                    {
                        List<string> listPath = texto.Split('/').ToList();
                        strPath = listPath[0];
                        listPath.RemoveAt(0);

                        // Recorremos el path y crear el directorios
                        foreach (string directorio in listPath)
                        {
                            strPath += "\\" + directorio;
                            if (!Directory.Exists(strPath))
                            {
                                DirectoryInfo di = Directory.CreateDirectory(strPath);
                            }
                        }
                    }
                    // Creamos el fichero
                    else if (Regex.IsMatch(texto, @"[A-Z|a-z|0-9]+"))
                    {
                        if (!File.Exists(texto))
                        {
                            string NewText = texto.TrimStart(new char[] { '-' });
                            StreamWriter fichero = File.CreateText(strPath.Trim() + "\\" + NewText.Trim());
                            fichero.Close();
                        }
                    }
                }
                MessageBox.Show("Datos creados correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
