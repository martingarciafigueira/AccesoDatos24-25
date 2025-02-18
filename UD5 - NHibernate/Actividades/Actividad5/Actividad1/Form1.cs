using Actividad1.Entidades;
using Actividad1.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form1: Form
    {
        private InstitutoService institutoService = new InstitutoService();
        private AsignaturaService asignaturaService = new AsignaturaService();
        private EstudianteService estudianteService = new EstudianteService();

        public Form1()
        {
            InitializeComponent();
            Configuraciones.NHibernateUtil.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevo = new Instituto();
            nuevo.NombreInstituto = textBox1.Text;
            nuevo.DescripcionInstituto = textBox2.Text;
            institutoService.Save(nuevo);
        }
    }
}
