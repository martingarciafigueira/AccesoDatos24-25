using Actividad5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public interface IPanaderiaService
    {
        List<Panaderia> ObtenerPanaderias();
        void AgregarPanaderia(Panaderia panaderia);
    }
}
