using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03Pokemon.Clases
{
    static class CadenasSql
    {

        public static string SelectPokemon = "SELECT p.PokemonId" +
                                              " ,nombre" +
                                              " ,peso " +
                                              " ,altura " +
                                              " ,ps" +
                                              " ,ataque" +
                                              " ,defensa" +
                                              " ,especial" +
                                              " , velocidad	" +
                                              " ,COALESCE(pe.pokemon_evolucionado,0) pokemon_evolucionado" +
                                              " ,COALESCE((SELECT nombre from pokemon where PokemonId = pe.pokemon_origen),'O') nombre_evolucion" +                                              
                                              " FROM pokemon p FULL JOIN evoluciona_de pe ON p.PokemonId = pe.pokemon_origen " +
                                              " INNER JOIN estadisticas_base es ON p.PokemonId = es.PokemonId " +                                              
                                              " order by PokemonId asc;";

        public static string SelectPokemonNoWhere = "SELECT p.PokemonId" +
                                                      " ,nombre" +
                                                      " ,peso " +
                                                      " ,altura " +
                                                      " ,ps" +
                                                      " ,ataque" +
                                                      " ,defensa" +
                                                      " ,especial" +
                                                      " , velocidad	" +
                                                      " ,COALESCE(pe.pokemon_evolucionado,0) pokemon_evolucionado" +
                                                      " ,COALESCE((SELECT nombre from pokemon where PokemonId = pe.pokemon_origen),'O') nombre_evolucion" +                                                      
                                                      " FROM pokemon p FULL JOIN evoluciona_de pe ON p.PokemonId = pe.pokemon_origen " +
                                                      " INNER JOIN estadisticas_base es ON p.PokemonId = es.PokemonId ";                                                      
                                                      

        public static string SelectEstadisticasBase = "SELECT PokemonId " +
                                                          ", ps" +
                                                          ", ataque" +
                                                          ", defensa" + 
                                                          ", especial" + 
                                                          ", velocidad" +
                                                  "FROM estadisticas_base;";


        public static string SelectTipos = "SELECT id_tipo, nombre " +
                                           " FROM dbo.tipo tipo;";


    }
}
