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
    public partial class FormSave : Form
    {
        public FormSave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strMensaje = txtMensaje.Text;
            if (strMensaje == "")
            {
                MessageBox.Show("Escriba un mensaje por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaFichero = openFileDialog.FileName;
                
                    StreamWriter fichero = File.AppendText(rutaFichero);
                    fichero.WriteLine(strMensaje);
                    fichero.Close();
                    MessageBox.Show("Datos guardados correctamente", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
