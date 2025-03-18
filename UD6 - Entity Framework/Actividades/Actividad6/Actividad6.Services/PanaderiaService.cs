using Actividad6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Services
{
    public class PanaderiaService : IPanaderiaService
    {
        private readonly PanaderiaContext _context;
        public PanaderiaService(PanaderiaContext context) { _context = context; }

        public List<Panaderia> ObtenerPanaderias() => _context.Panaderias.ToList();
        public void AgregarPanaderia(Panaderia panaderia)
        {
            _context.Panaderias.Add(panaderia);
            _context.SaveChanges();
        }
    }
}
