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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        // Form guardar texto
        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave save = new FormSave();
            save.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = File.OpenText(openFileDialog.FileName);
                string strLine;
                txtLog.Text = "";
                do
                {
                    strLine = rd.ReadLine();
                    if (strLine != null)
                    {
                        txtLog.Text += strLine + Environment.NewLine;
                    }
                }
                while (strLine != null);
                rd.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate update = new FormUpdate();
            update.Show();
        }
    }
}
