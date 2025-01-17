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

namespace Ejercicio1
{
    public partial class FormUpdate : Form
    {
        string path = "";

        public FormUpdate()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            // Abrimos el menú de selección de ficheros
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                StreamReader rd = File.OpenText(path);
                string strLine;
                txtUpdate.Text = "";
                do
                {
                    strLine = rd.ReadLine();
                    if (strLine != null)
                    {
                        txtUpdate.Text += strLine + Environment.NewLine;
                    }
                }
                while (strLine != null);
                rd.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> listaMS = txtUpdate.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            StreamWriter fichero = File.CreateText(path);

            foreach (string strMensaje in listaMS)
            {
                fichero.WriteLine(strMensaje.Trim());
            }
            fichero.Close();
            MessageBox.Show("Datos modificados correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
