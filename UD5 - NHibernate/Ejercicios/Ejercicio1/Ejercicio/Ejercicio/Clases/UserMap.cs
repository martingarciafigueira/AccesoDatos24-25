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
    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Table("users");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Name, m => m.NotNullable(true));
            Property(x => x.Email, m =>
            {
                m.NotNullable(true);
                m.Unique(true);
            });
        }
    }
}
