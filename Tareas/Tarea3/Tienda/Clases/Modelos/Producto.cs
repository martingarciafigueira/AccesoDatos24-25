using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03Pokemon.Tienda.Clases
{
    public  class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int CodigoFabricante { get; set; }



        public override string ToString()
        {
            return this.Nombre + " Precio: " + this.Precio ;
        }
    }
}
