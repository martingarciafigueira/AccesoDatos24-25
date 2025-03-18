using Actividad6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Services
{
    public interface IPanaderiaService
    {
        List<Panaderia> ObtenerPanaderias();
        void AgregarPanaderia(Panaderia panaderia);
    }
}
