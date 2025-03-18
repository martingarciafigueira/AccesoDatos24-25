using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03Pokemon.Tienda.Database
{
    static class CadenasSql
    {

        public static string SelectProductos = "SELECT codigo,nombre,precio,codigo_fabricante" +
                                               "  FROM dbo.producto;";


        public static string SelectProductosFiltro = "SELECT codigo,nombre,precio,codigo_fabricante " +
                                                     "  FROM dbo.producto " +
                                                     "  WHERE nombre  like @nombre_producto ;";


        public static string SelectFabricantes = "SELECT codigo,nombre " +
                                                      " FROM fabricante;";

        public static string SelectFabricantesFiltro = "SELECT codigo,nombre " +
                                                      " FROM fabricante" +
                                                      " WHERE nombre LIKE @nombre_fabricante;";

    }
}
