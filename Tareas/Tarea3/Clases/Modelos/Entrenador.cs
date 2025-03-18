using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Pokemon.Clases
{
    public class Entrenador    
    {
        string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        List<Pokemon> listaPokemos = new List<Pokemon>();
        public List<Pokemon> ListaPokemos { get => listaPokemos; set => listaPokemos = value; }

    }




}
