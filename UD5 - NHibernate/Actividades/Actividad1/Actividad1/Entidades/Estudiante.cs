using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Entidades
{
    public class Estudiante
    {
        public virtual int IdEstudiante { get; set; }
        public virtual string NombreEstudiante { get; set; }
        public virtual string ApellidoEstudiante { get; set; }
        public virtual string DocumentoEstudiante { get; set; }
    }
}
