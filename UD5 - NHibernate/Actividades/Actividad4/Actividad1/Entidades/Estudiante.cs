using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Estudiante", NameType = typeof(Estudiante))]
    public class Estudiante
    {
        [Id(Name = "IdEstudiante", Column = "IdEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdEstudiante { get; set; }

        [Property(Column = "NombreEstudiante", Type = "string", NotNull = true)]
        public virtual string NombreEstudiante { get; set; }

        [Property(Column = "ApellidoEstudiante", Type = "string", NotNull = true)]
        public virtual string ApellidoEstudiante { get; set; }

        [Property(Column = "DocumentoEstudiante", Type = "string", NotNull = true)]
        public virtual string DocumentoEstudiante { get; set; }
    }
}
