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
    public partial class FormEstudiante : Form
    {
        private EstudianteService estudianteService;
        private Estudiante unEstudiante;

        public FormEstudiante()
        {
            InitializeComponent();
        }

        public FormEstudiante(Estudiante _unEstudiante)
        {
            this.estudianteService = new EstudianteService();
            this.unEstudiante = _unEstudiante;
            InitializeComponent();
            this.configurar();
        }

        private bool hasEstudiante()
        {
            return this.unEstudiante != null;
        }

        private void configurar()
        {
            if (this.hasEstudiante())
            {
                this.lblTitulo.Text = "Actualizar Estudiante";
                this.txtNombreEstudiante.Text = this.unEstudiante.NombreEstudiante;
                this.txtApellidoEstudiante.Text = this.unEstudiante.ApellidoEstudiante;
                this.txtDocumentoEstudiante.Text = this.unEstudiante.DocumentoEstudiante;
            }
            else
            {
                this.lblTitulo.Text = "Registrar estudiante";
            }
        }

        private void GuardarEstudiante()
        {
            if (this.hasEstudiante())
            {
                this.unEstudiante.NombreEstudiante = this.txtNombreEstudiante.Text;
                this.unEstudiante.ApellidoEstudiante = this.txtApellidoEstudiante.Text;
                this.unEstudiante.DocumentoEstudiante = this.txtDocumentoEstudiante.Text;
                this.estudianteService.Update(this.unEstudiante);
            }
            else
            {
                Estudiante nuevoEstudiante = new Estudiante();
                nuevoEstudiante.NombreEstudiante = this.txtNombreEstudiante.Text;
                nuevoEstudiante.ApellidoEstudiante = this.txtApellidoEstudiante.Text;
                nuevoEstudiante.DocumentoEstudiante = this.txtDocumentoEstudiante.Text;
                this.estudianteService.Save(nuevoEstudiante);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarEstudiante();
            this.Close();
        }
    }
}
