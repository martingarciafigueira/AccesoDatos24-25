using ActividadNHibernate.Servicios;
using ActividadNHibernate.Vistas;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadNHibernate
{
    public partial class frmGeneral : Form
    {

        private InstitutoService institutoService = new InstitutoService();

        public frmGeneral()
        {
            InitializeComponent();
            Configuraciones.NHibernateUtil.Start();
        }

        private void cargarListFormInstitutos()
        {
            this.pnlContenedor.Controls.Clear();
            ListFormInstituto viewListInstituto = new ListFormInstituto();
            viewListInstituto.TopLevel = false;
            viewListInstituto.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(viewListInstituto);
            viewListInstituto.Show();
        }

        private void cargarListFormAsignaturas()
        {
            this.pnlContenedor.Controls.Clear();
            ListFormAsignatura viewListAsignatura = new ListFormAsignatura();
            viewListAsignatura.TopLevel = false;
            viewListAsignatura.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(viewListAsignatura);
            viewListAsignatura.Show();
        }

        private void cargarListFormEstudiantes()
        {
            this.pnlContenedor.Controls.Clear();
            ListFormEstudiante viewListEstudiante = new ListFormEstudiante();
            viewListEstudiante.TopLevel = false;
            viewListEstudiante.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(viewListEstudiante);
            viewListEstudiante.Show();
        }

        private void btnInstituto_Click(object sender, EventArgs e)
        {
            cargarListFormInstitutos();
        }

        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            cargarListFormAsignaturas();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            cargarListFormEstudiantes();
        }
    }
}
