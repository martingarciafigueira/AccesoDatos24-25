using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Instituto", NameType = typeof(Instituto))]
    public class Instituto
    {
        [Id(Name = "IdInstituto", Column = "IdInstituto", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdInstituto { get; set; }

        [Property(Column = "NombreInstituto", Type = "string", NotNull = true)]
        public virtual string NombreInstituto { get; set; }

        [Property(Column = "DescripcionInstituto", Type = "string", NotNull = true)]
        public virtual string DescripcionInstituto { get; set; }
    }
}
