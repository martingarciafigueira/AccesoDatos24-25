using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Pokemon.Clases
{
    public class Movimientos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return this.Nombre;
        }
    }

}
