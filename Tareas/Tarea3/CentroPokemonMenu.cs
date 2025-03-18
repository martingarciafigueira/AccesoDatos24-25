using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Tarea03Pokemon.Clases;

namespace Tarea03Pokemon
{
    public partial class CentroPokemonMenu : Form
    {
        
        static BindingList<Pokemon> listaPokemonMostrar = new BindingList<Pokemon>();
        BindingList<Pokemon> ObtenerEvolucionesPrimerasPokemon = new BindingList<Pokemon>();
        BindingList<Pokemon> ObtenerEvolucionesFinales = new BindingList<Pokemon>();


        CentroPokemon centroPokemon = new CentroPokemon();
        public CentroPokemonMenu()
        {
            InitializeComponent();        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaPokemonMostrar = centroPokemon.Lista;
            lbPokemons.DataSource = listaPokemonMostrar;      
            lbPokemonEvolucionesPrevias.DataSource = ObtenerEvolucionesPrimerasPokemon;
            lbPokemonEvolucionesAltas.DataSource = ObtenerEvolucionesFinales;

            cbTipo.DataSource = centroPokemon.GetTipos();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarFiltros();

        }

        private void lbPokemons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var pokemon = (Pokemon)lbPokemons.SelectedItem;
            lbPokemonEvolucionesAltas.DataSource = centroPokemon.ObtenerEvolucionesFinales(pokemon.PokemonId);
            //lbPokemonEvolucionesAltas.DataSource = listas;
            lbPokemonEvolucionesAltas.Refresh();
            lbPokemonEvolucionesPrevias.DataSource = centroPokemon.ObtenerEvolucionesPreviasPokemon(pokemon.PokemonId);
            lbPokemonEvolucionesPrevias.Refresh();
            lbAtaques.DataSource = centroPokemon.ObtenerAtaques(pokemon.PokemonId);
        }

        private void btCombate_Click(object sender, EventArgs e)
        {
            Combate formCombate = new Combate();
            formCombate.Owner = this;
            formCombate.ShowDialog();
        }

        public BindingList<Pokemon> listaActual()
        {
            return centroPokemon.Lista;
        }

        public BindingList<Entrenador> obtenerEquipos()
        {
            return centroPokemon.ObtenerEquipos();
        }
        private void buscarFiltros()
        {

            float numberPeso;
            if (float.TryParse(tbPeso.Text, out numberPeso))
            {
                Console.WriteLine("The parsed number is: " + numberPeso);
            }
            else
            {
                Console.WriteLine("The input could not be parsed to an integer.");
            }
            float numberAltura;
            if (float.TryParse(tbAltura.Text, out numberAltura))
            {
                Console.WriteLine("The parsed number is: " + numberAltura);
            }
            else
            {
                Console.WriteLine("The input could not be parsed to an integer.");
            }
            centroPokemon.filtrarListaPokemon(cbTipo.Text, numberPeso, numberAltura);
        }       

        private void cbTipo_TextChanged(object sender, EventArgs e)
        {
            buscarFiltros();
        }

        private void tbPeso_TextChanged(object sender, EventArgs e)
        {
            buscarFiltros();
        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {
            buscarFiltros();
        }
    }
}
