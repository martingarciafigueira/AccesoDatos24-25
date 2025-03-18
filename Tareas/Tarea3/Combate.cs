using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Tarea03Pokemon.Clases;

namespace Tarea03Pokemon
{
    public partial class Combate : Form
    {
        private BindingList<Entrenador> listaEntrenadores = new BindingList<Entrenador>();

        private BindingList<String> logCombate = new BindingList<string>();
        delegate void delegado();
        private bool combateFinaliza = false;

        Pokemon[] equipoAzul = new Pokemon[6];
        Pokemon[] equipoRojo = new Pokemon[6];
        public Combate()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Combate_Load(object sender, EventArgs e)
        {

            lbLogCombate.DataSource = logCombate;

            var formOwner = (CentroPokemonMenu)this.Owner;
            listaEntrenadores = formOwner.obtenerEquipos();
            var listaEntrenador = formOwner.obtenerEquipos();
            int posicionEquipo = 1;

            int numeroEquipo = 1;
            int posicionPokemon = 0;

            foreach (Entrenador entrador in listaEntrenador)
            {
                foreach (Pokemon equipo in entrador.ListaPokemos)
                {
                    //  Generamos equipos para combate
                    if (numeroEquipo == 1)
                    {
                        equipoAzul[posicionPokemon] = equipo;
                        posicionPokemon++;
                    }
                    else if (numeroEquipo == 2)
                    {
                        equipoRojo[posicionPokemon] = equipo;
                        posicionPokemon++;
                    }
                    SetEquipos(tbEquipoAzulPrimerPokemon, equipo, posicionEquipo);

                }
                posicionPokemon = 0;
                numeroEquipo++;
                posicionEquipo = posicionEquipo + 1;
            }

        }

        private void reiniciarCombate()
        {
            tbEquipoAzulPrimerPokemon.Clear();
            tbEquipoAzulSegundoPokemon.Clear();
            tbEquipoAzulTercerPokemon.Clear();
            tbEquipoAzulCuartoPokemon.Clear();
            tbEquipoAzulQuitoPokemon.Clear();
            tbEquipoAzulSextoPokemon.Clear();

            tbEquipoRojoPrimerPokemon.Clear();
            tbEquipoRojoSegundoPokemon.Clear();
            tbEquipoRojoTercerPokemon.Clear();
            tbEquipoRojoCuartoPokemon.Clear();
            tbEquipoRojoQuintoPokemon.Clear();
            tbEquipoRojoSextoPokemon.Clear();
            int posicionEquipo = 1;

            int numeroEquipo = 1;
            int posicionPokemon = 0;
            var formOwner = (CentroPokemonMenu)this.Owner;
            listaEntrenadores = formOwner.obtenerEquipos();

            foreach (Entrenador entrador in listaEntrenadores)
            {
                foreach (Pokemon equipo in entrador.ListaPokemos)
                {
                    //  Generamos equipos para combate
                    if (numeroEquipo == 1)
                    {
                        equipoAzul[posicionPokemon] = equipo;
                        posicionPokemon++;
                    }
                    else if (numeroEquipo == 2)
                    {
                        equipoRojo[posicionPokemon] = equipo;
                        posicionPokemon++;
                    }
                    SetEquipos(tbEquipoAzulPrimerPokemon, equipo, posicionEquipo);

                }
                posicionPokemon = 0;
                numeroEquipo++;
                posicionEquipo = posicionEquipo + 1;
            }
        }

        private void SetEquipos(TextBox tbEquipoAzulPrimerPokemon, Pokemon pk, int equipo)
        {
            if (equipo == 1)
            {
                if (tbEquipoAzulPrimerPokemon.Text.Length == 0)
                {
                    tbEquipoAzulPrimerPokemon.Text = pk.Nombre;
                    progresBarAzulPrimerPokemon.Maximum = pk.PS;
                    progresBarAzulPrimerPokemon.Value = pk.PS;
                }
                else if (tbEquipoAzulSegundoPokemon.Text.Length == 0)
                {

                    tbEquipoAzulSegundoPokemon.Text = pk.Nombre;
                    progresBarAzulSegundoPokemon.Maximum = pk.PS;
                    progresBarAzulSegundoPokemon.Value = pk.PS;
                }
                else if (tbEquipoAzulTercerPokemon.Text.Length == 0)
                {
                    tbEquipoAzulTercerPokemon.Text = pk.Nombre;
                    progresBarAzulTercerPokemon.Maximum = pk.PS;
                    progresBarAzulTercerPokemon.Value = pk.PS;
                }
                else if (tbEquipoAzulCuartoPokemon.Text.Length == 0)
                {
                    tbEquipoAzulCuartoPokemon.Text = pk.Nombre;
                    progresBarAzulCuartoPokemon.Maximum = pk.PS;
                    progresBarAzulCuartoPokemon.Value = pk.PS;
                }
                else if (tbEquipoAzulQuitoPokemon.Text.Length == 0)
                {
                    tbEquipoAzulQuitoPokemon.Text = pk.Nombre;
                    progresBarAzulQuintoPokemon.Maximum = pk.PS;
                    progresBarAzulQuintoPokemon.Value = pk.PS;
                }
                else if (tbEquipoAzulSextoPokemon.Text.Length == 0)
                {
                    tbEquipoAzulSextoPokemon.Text = pk.Nombre;
                    progresBarAzulSextoPokemon.Maximum = pk.PS;
                    progresBarAzulSextoPokemon.Value = pk.PS;
                }
            }
            else if (equipo == 2)
            {
                if (tbEquipoRojoPrimerPokemon.Text.Length == 0)
                {
                    tbEquipoRojoPrimerPokemon.Text = pk.Nombre;
                    progresBarRojoPrimerPokemon.Maximum = pk.PS;
                    progresBarRojoPrimerPokemon.Value = pk.PS;
                }
                else if (tbEquipoRojoSegundoPokemon.Text.Length == 0)
                {
                    tbEquipoRojoSegundoPokemon.Text = pk.Nombre;
                    progresBarRojoSegundoPokemon.Maximum = pk.PS;
                    progresBarRojoSegundoPokemon.Value = pk.PS;
                }
                else if (tbEquipoRojoTercerPokemon.Text.Length == 0)
                {
                    tbEquipoRojoTercerPokemon.Text = pk.Nombre;
                    progresBarRojoTercerPokemon.Maximum = pk.PS;
                    progresBarRojoTercerPokemon.Value = pk.PS;
                }
                else if (tbEquipoRojoCuartoPokemon.Text.Length == 0)
                {
                    tbEquipoRojoCuartoPokemon.Text = pk.Nombre;
                    progresBarRojoCuartoPokemon.Maximum = pk.PS;
                    progresBarRojoCuartoPokemon.Value = pk.PS;
                }
                else if (tbEquipoRojoQuintoPokemon.Text.Length == 0)
                {
                    tbEquipoRojoQuintoPokemon.Text = pk.Nombre;
                    progresBarRojoQuintoPokemon.Maximum = pk.PS;
                    progresBarRojoQuintoPokemon.Value = pk.PS;
                }
                else if (tbEquipoRojoSextoPokemon.Text.Length == 0)
                {
                    tbEquipoRojoSextoPokemon.Text = pk.Nombre;
                    progresBarRojoSextoPokemon.Maximum = pk.PS;
                    progresBarRojoSextoPokemon.Value = pk.PS;
                }
            }




        }

        private void btEmpezarCombate_Click(object sender, EventArgs e)
        {

            Thread parking = new Thread(iniciarHilo);
            //Iniciamos hilo
            parking.Start();

        }
        private void iniciarHilo()
        {
            //iniciar();
            delegado IniciarParking = new delegado(HiloCombate);
            //Iniciamos carrera
            IniciarParking.Invoke();

        }
        private void HiloCombate()
        {
            combateFinaliza=false;
            while (!combateFinaliza)
            {
                Thread.Sleep(1000);
                EmpezarCombate();
            }
        }
        private void EmpezarCombate()
        {
            bool tenemosGanador = false;
            bool existePokemonActual = false;
            int contadorEquipoAzul = 0;
            int contadorEquipoRojo = 0;
            Pokemon pkEquipoAzul = new Pokemon();
            Pokemon pkEquipoRojo = new Pokemon();
            // Equipo Azul
            while (!existePokemonActual)
            {
                if (6 == contadorEquipoAzul)
                {
                    tenemosGanador = true;
                    logCombate.Add("Equipo Rojo GANADOR!!!!");
                    break;
                }
                if (equipoAzul[contadorEquipoAzul].PS > 0)
                {
                    pkEquipoAzul = equipoAzul[contadorEquipoAzul];
                    break;
                }
                contadorEquipoAzul++;
            }

            //Equipo Rojo
            existePokemonActual = false;
            while (!existePokemonActual)
            {
                if (6 == contadorEquipoRojo)
                {
                    tenemosGanador = true;
                    logCombate.Add("Equipo AZUL GANADOR!!!!");
                    break;
                }
                if (equipoRojo[contadorEquipoRojo].PS > 0)
                {
                    pkEquipoRojo = equipoRojo[contadorEquipoRojo];
                    break;
                }
                contadorEquipoRojo++;
            }

            if (!tenemosGanador)
            {
                if (pkEquipoAzul.PS > pkEquipoRojo.PS)
                {
                    pkEquipoAzul.PS = pkEquipoAzul.PS - pkEquipoRojo.PS;
                    pkEquipoRojo.PS = 0;
                    logCombate.Add("Equipo Rojo Pierde a " + pkEquipoRojo.Nombre);

                }
                else if (pkEquipoAzul.PS < pkEquipoRojo.PS)
                {
                    pkEquipoRojo.PS = pkEquipoRojo.PS - pkEquipoAzul.PS;
                    pkEquipoAzul.PS = 0;
                    logCombate.Add("Equipo Azul Pierde a " + pkEquipoAzul.Nombre);
                }
                else
                {
                    if (pkEquipoAzul.Altura > pkEquipoRojo.Altura)
                    {
                        //kEquipoAzul.PS = pkEquipoAzul.PS - pkEquipoRojo.PS;
                        pkEquipoRojo.PS = 0;
                        logCombate.Add("Equipo Rojo Pierde a " + pkEquipoRojo.Nombre);

                    }
                    else if (pkEquipoAzul.Altura < pkEquipoRojo.Altura)
                    {

                        ///pkEquipoRojo.PS = pkEquipoRojo.PS - pkEquipoAzul.PS;
                        pkEquipoAzul.PS = 0;
                        logCombate.Add("Equipo Azul Pierde a " + pkEquipoAzul.Nombre);
                    }
                    else
                    {
                        logCombate.Add("EMPATE PIERDEN LOS DOS!");
                        pkEquipoRojo.PS = 0;
                        pkEquipoAzul.PS = 0;
                    }

                }
                equipoAzul[contadorEquipoAzul] = pkEquipoAzul;
                equipoRojo[contadorEquipoRojo] = pkEquipoRojo;

                actualizarVista(1, pkEquipoAzul, contadorEquipoAzul);
                actualizarVista(2, pkEquipoRojo, contadorEquipoRojo);

            }
            else
            {
                combateFinaliza = true;
                MessageBox.Show("Tenemos ganador");
            }

        }

        private void actualizarVista(int equipo, Pokemon pk, int posicion)
        {
            if (equipo == 1)
            {
                if (posicion == 0)
                {
                    progresBarAzulPrimerPokemon.Value = pk.PS;
                }
                else if (posicion == 1)
                {
                    progresBarAzulSegundoPokemon.Value = pk.PS;
                }
                else if (posicion == 2)
                {
                    progresBarAzulTercerPokemon.Value = pk.PS;
                }
                else if (posicion == 3)
                {
                    progresBarAzulCuartoPokemon.Value = pk.PS;
                }
                else if (posicion == 4)
                {
                    progresBarAzulQuintoPokemon.Value = pk.PS;
                }
                else if (posicion == 5)
                {
                    progresBarAzulSextoPokemon.Value = pk.PS;
                }
            }
            else if (equipo == 2)
            {
                if (posicion == 0)
                {
                    progresBarRojoPrimerPokemon.Value = pk.PS;
                }
                else if (posicion == 1)
                {
                    progresBarRojoSegundoPokemon.Value = pk.PS;
                }
                else if (posicion == 2)
                {
                    progresBarRojoTercerPokemon.Value = pk.PS;
                }
                else if (posicion == 3)
                {
                    progresBarRojoCuartoPokemon.Value = pk.PS;
                }
                else if (posicion == 4)
                {
                    progresBarRojoQuintoPokemon.Value = pk.PS;
                }
                else if (posicion == 5)
                {
                    progresBarRojoSextoPokemon.Value = pk.PS;
                }
            }
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            reiniciarCombate();
        }
    }
}
