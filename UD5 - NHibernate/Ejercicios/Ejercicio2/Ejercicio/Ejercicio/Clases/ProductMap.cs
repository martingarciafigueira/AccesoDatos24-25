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
    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Table("products");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Name, m => m.NotNullable(true));
            Property(x => x.Price, m => m.NotNullable(true));
            ManyToOne(x => x.Category, m =>
            {
                m.Column("category_id");
                m.NotNullable(true);
            });
        }
    }
}
