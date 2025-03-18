using Actividad5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public interface IProductoService
    {
        List<Producto> ObtenerProductos();
        void AgregarProducto(Producto producto);
    }
}
