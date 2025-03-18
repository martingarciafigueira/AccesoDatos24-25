using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Pokemon.Clases.Modelos
{
    public class Tipos
    {
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
       
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
