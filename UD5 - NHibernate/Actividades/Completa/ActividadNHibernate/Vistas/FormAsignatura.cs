using ActividadNHibernate.Entidades;
using ActividadNHibernate.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadNHibernate.Vistas
{
    public partial class FormAsignatura : Form
    {
        private AsignaturaService asignaturaService;
        private Asignatura unaAsignatura;

        public FormAsignatura()
        {
            InitializeComponent();
        }

        public FormAsignatura(Asignatura _unaAsignatura)
        {
            this.asignaturaService = new AsignaturaService();
            this.unaAsignatura = _unaAsignatura;
            InitializeComponent();
            this.configurar();
        }

        private bool hasAsignatura()
        {
            return this.unaAsignatura != null;
        }

        private void configurar()
        {
            if (this.hasAsignatura())
            {
                this.lblTitulo.Text = "Actualizar Asignatura";
                this.txtNombreAsignatura.Text = this.unaAsignatura.NombreAsignatura;
                this.txtDescripcionAsignatura.Text = this.unaAsignatura.NombreAsignatura;
            }
            else
            {
                this.lblTitulo.Text = "Registrar asignatura";
            }
        }

        private void GuardarAsignatura()
        {
            if (this.hasAsignatura())
            {
                this.unaAsignatura.NombreAsignatura = this.txtNombreAsignatura.Text;
                this.unaAsignatura.DescripcionAsignatura = this.txtDescripcionAsignatura.Text;
                this.asignaturaService.Update(this.unaAsignatura);
            }
            else
            {
                Asignatura nuevaAsignatura = new Asignatura();
                nuevaAsignatura.NombreAsignatura = this.txtNombreAsignatura.Text;
                nuevaAsignatura.DescripcionAsignatura = this.txtDescripcionAsignatura.Text;
                this.asignaturaService.Save(nuevaAsignatura);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarAsignatura();
            this.Close();
        }
    }
}
