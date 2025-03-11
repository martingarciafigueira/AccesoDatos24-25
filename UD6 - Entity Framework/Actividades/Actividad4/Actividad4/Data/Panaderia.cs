using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Data
{
    public class Panaderia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Relación muchos a muchos con Producto
        public List<PanaderiaProducto> PanaderiasProductos { get; set; } = new List<PanaderiaProducto>();

    }
}
