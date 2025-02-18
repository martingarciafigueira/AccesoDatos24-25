using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Asignatura", NameType = typeof(Asignatura))]
    public class Asignatura
    {
        [Id(Name = "IdAsignatura", Column = "IdAsignatura", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdAsignatura { get; set; }
        [Property(Column = "NombreAsignatura", Type = "string", NotNull = true)]
        public virtual String NombreAsignatura { get; set; }
        [Property(Column = "DescripcionAsignatura", Type = "string", NotNull = true)]
        public virtual String DescripcionAsignatura { get; set; }
    }
}
