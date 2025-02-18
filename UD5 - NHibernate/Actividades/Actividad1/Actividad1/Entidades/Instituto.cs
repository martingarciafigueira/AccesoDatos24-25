using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Entidades
{
    public class Instituto
    {
        public virtual int IdInstituto { get; set; }
        public virtual string NombreInstituto { get; set; }
        public virtual string DescripcionInstituto { get; set; }
    }
}
