using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Pokemon.Tienda.Clases
{
    public class Fabricante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        List<Producto> productos = new List<Producto>();


        public override string ToString()
        {
            return this.Nombre ;
        }
    }
}
