﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Data
{
    public class PanaderiaProducto
    {
        public int PanaderiaId { get; set; }
        public Panaderia Panaderia { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
