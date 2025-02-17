using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class CuentaMap : ClassMapping<Cuenta>
    {
        public CuentaMap()
        {
            Table("accounts");
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.IBAN, m => m.NotNullable(true));
            Property(x => x.Nombre, m => m.NotNullable(true));
            Property(x => x.Balance, m => m.NotNullable(true));
        }
    }
}
