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
    public partial class FormInstituto : Form
    {
        private InstitutoService institutoService;
        private Instituto unInstituto;

        public FormInstituto()
        {
            InitializeComponent();
        }

        public FormInstituto(Instituto _instituto)
        {
            this.institutoService = new InstitutoService();
            this.unInstituto = _instituto;
            InitializeComponent();
            this.configurar();
        }

        private bool hasInstituto()
        {
            return this.unInstituto != null;
        }

        private void configurar()
        {
            if (this.hasInstituto())
            {
                this.lblTitulo.Text = "Actualizar Instituto";
                this.txtNombreInstituto.Text = this.unInstituto.NombreInstituto;
                this.txtDescripcionInstituto.Text = this.unInstituto.DescripcionInstituto;
            }
            else
            {
                this.lblTitulo.Text = "Registrar instituto";
            }
        }

        private void GuardarInstituto()
        {
            if (this.hasInstituto())
            {
                this.unInstituto.NombreInstituto = this.txtNombreInstituto.Text;
                this.unInstituto.DescripcionInstituto = this.txtDescripcionInstituto.Text;
                this.institutoService.Update(this.unInstituto);
            }
            else
            {
                Instituto nuevoInstituto = new Instituto();
                nuevoInstituto.NombreInstituto = this.txtNombreInstituto.Text;
                nuevoInstituto.DescripcionInstituto = this.txtDescripcionInstituto.Text;
                this.institutoService.Save(nuevoInstituto);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarInstituto();
            this.Close();
        }
    }
}
