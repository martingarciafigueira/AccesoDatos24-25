using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Data
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación muchos a muchos con Panaderia
        public List<PanaderiaProducto> PanaderiasProductos { get; set; } = new List<PanaderiaProducto>();
    }
}
