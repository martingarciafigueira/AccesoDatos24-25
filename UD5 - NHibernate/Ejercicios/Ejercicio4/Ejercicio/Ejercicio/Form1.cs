using Ejercicio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        Repository repository;
        public Form1()
        {
            repository = new Repository();
            InitializeComponent();
            CargarTiposVehiculos();
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string fabricante, modelo, tipo;
            int anho, numeroRuedas;
            decimal velocidadMaxima;

            fabricante = txtFabricante.Text;
            modelo = txtModelo.Text;
            tipo = cbTipo.SelectedItem.ToString();

            int.TryParse(txtAnho.Text, out anho);
            int.TryParse(txtNumRuedas.Text, out numeroRuedas);

            decimal.TryParse(txtVelocidadMax.Text, out velocidadMaxima);

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Fabricante = fabricante;
            vehiculo.Modelo = modelo;
            vehiculo.Tipo = tipo;
            vehiculo.Anho = anho;
            vehiculo.NumeroRuedas = numeroRuedas;

            vehiculo.VelocidadMaxima = velocidadMaxima;

            repository.AddOrUpdate(vehiculo);
        }

        public void CargarTiposVehiculos()
        {
            List<string> tipos = new List<string> { "COCHE", "MOTO", "BICICLETA" };
            cbTipo.DataSource = tipos;
            cbVehiculoSeleccionado.DataSource = tipos;
        }

        private void cbVehiculoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo;
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            tipo = cbVehiculoSeleccionado.SelectedItem.ToString();

            listaVehiculos = repository.GetAll().Where(x=> x.Tipo == tipo).ToList() as List<Vehiculo>;
            lstVehiculosAsociados.DataSource = listaVehiculos;
        }
    }
}
