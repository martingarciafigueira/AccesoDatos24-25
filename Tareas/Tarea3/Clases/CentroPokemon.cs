using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Tarea03Pokemon.Clases.Modelos;

namespace Tarea03Pokemon.Clases
{
    //Esta clase fue un intento de controlar 
    // Tengo que buscar otra forma, esta no me convence
    public class CentroPokemon
    {
        CentroPokemonMenu vista;
        private string texto;


        private BindingList<Pokemon> lista = new BindingList<Pokemon>();


        public BindingList<Pokemon> Lista { get => lista; set => lista = value; }

        private BindingList<Entrenador> listaEntrenadores = new BindingList<Entrenador>();
        public BindingList<Entrenador> ListaEntrenadores { get => listaEntrenadores; set => listaEntrenadores = value; }


        public string Texto { get => texto; set => texto = value; }

        PokemonDatabase pokemonDatabase = new PokemonDatabase();
        public CentroPokemon()
        {
            Lista = pokemonDatabase.listaPokemon();
        }       
        public BindingList<Pokemon> ObtenerEvolucionesFinales(int PokemonId)
        {
            return pokemonDatabase.ObtenerEvolucionesFinales(PokemonId);
        }

        public BindingList<Pokemon> ObtenerEvolucionesPreviasPokemon(int PokemonId)
        {
            return pokemonDatabase.ObtenerEvolucionesPreviasPokemon(PokemonId);
        }
        public object ObtenerAtaques(int PokemonId)
        {
            return pokemonDatabase.GetAtaques(PokemonId);
        }

        public void filtrarListaPokemon(string tipo, float peso, float altura)
        {
            pokemonDatabase.FiltrarListaPokemon(tipo,peso,altura);
        }
        public List<Tipos> GetTipos()
        {
            return pokemonDatabase.GetTipos();
        }

        //Genera Equipo pokemo para el combate
        public BindingList<Entrenador> ObtenerEquipos()
        {
            //List<Pokemon> listaPokemonSin = new List<Pokemon>();
            var listaPokemonSin = pokemonDatabase.listaPokemonSinBindig();
            ListaEntrenadores.Clear();
            //Generamos el primer entrenado
            Entrenador primerEntrenador = new Entrenador();
            primerEntrenador.Nombre = "primer";
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                ///Generamos un numero ramdon para obtener el pokemos                 
                int randomNumber = random.Next(1, 100);
                //Obtenemos el pokemos segun el nuemro ramdon
                var pokemon_actual = listaPokemonSin.SingleOrDefault(pokemon => pokemon.PokemonId == randomNumber);
                primerEntrenador.ListaPokemos.Add(pokemon_actual);
                

            }
            ListaEntrenadores.Add(primerEntrenador);
            //Generamos el segundo entrenado
            Entrenador segundoEntrenador = new Entrenador();
            segundoEntrenador.Nombre = "segundo";
            for (int i = 0; i < 6; i++)
            {
                ///Generamos un numero ramdon para obtener el pokemos 
                int randomNumber = random.Next(1, 100);
                //Obtenemos el pokemos segun el nuemro ramdon
                var pokemon_actual = listaPokemonSin.SingleOrDefault(pokemon => pokemon.PokemonId == randomNumber);
                segundoEntrenador.ListaPokemos.Add(pokemon_actual);               
            }
            ListaEntrenadores.Add(segundoEntrenador);

            return ListaEntrenadores;
        }
    }


}
