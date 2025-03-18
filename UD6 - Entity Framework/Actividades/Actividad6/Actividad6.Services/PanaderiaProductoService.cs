using Actividad6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Services
{
    public class PanaderiaProductoService : IPanaderiaProductoService
    {
        private readonly PanaderiaContext _context;
        public PanaderiaProductoService(PanaderiaContext context) { _context = context; }

        public List<PanaderiaProducto> ObtenerRelaciones() => _context.PanaderiasProductos.ToList();
        public void AgregarRelacion(PanaderiaProducto relacion)
        {
            _context.PanaderiasProductos.Add(relacion);
            _context.SaveChanges();
        }
    }

}
