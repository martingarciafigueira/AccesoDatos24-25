using Actividad6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Services
{
    public class ProductoService : IProductoService
    {
        private readonly PanaderiaContext _context;
        public ProductoService(PanaderiaContext context) { _context = context; }

        public List<Producto> ObtenerProductos() => _context.Productos.ToList();
        public void AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }
    }
}
