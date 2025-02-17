using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    // Mapeo de la clase User a la tabla users en la base de datos
    public class VehiculoMap : ClassMapping<Vehiculo>
    {
        public VehiculoMap()
        {
            Table("vehiculos"); // Nombre de la tabla en la base de datos

            Id(x => x.Id, m => m.Generator(Generators.Identity));

            Property(x => x.Fabricante); // Mapeo de la propiedad Make a la columna make
            Property(x => x.Modelo); // Mapeo de la propiedad Model a la columna model
            Property(x => x.Anho); // Mapeo de la propiedad Year a la columna year
            Property(x => x.Tipo); // Mapeo de la propiedad Type a la columna type
            Property(x => x.NumeroRuedas); // Mapeo de la propiedad NumWheels a la columna num_wheels
            Property(x => x.VelocidadMaxima); // Mapeo de la propiedad MaxSpeed a la columna max_speed
        }
    }
}
