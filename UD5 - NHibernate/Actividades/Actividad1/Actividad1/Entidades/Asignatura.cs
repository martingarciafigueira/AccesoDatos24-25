using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Entidades
{
    public class Asignatura
    {
        public virtual int IdAsignatura { get; set; }
        public virtual string NombreAsignatura { get; set; }
        public virtual string DescripcionAsignatura { get; set; }
    }
}
