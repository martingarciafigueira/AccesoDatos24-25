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
    public class CategoryMap : ClassMapping<Category>
    {
        public CategoryMap()
        {
            Table("categories");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Name, m => m.NotNullable(true));
            Property(x => x.Description);
            Bag(x => x.Products, m =>
            {
                m.Key(k => k.Column("category_id"));
                m.Inverse(true);
                m.Fetch(CollectionFetchMode.Join);
            }, r => r.OneToMany());
        }
    }
}
