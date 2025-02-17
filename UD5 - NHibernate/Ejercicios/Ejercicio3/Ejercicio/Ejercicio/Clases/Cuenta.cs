using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Cuenta
    {
        public virtual int Id { get; set; }
        public virtual string IBAN { get; set; }
        public virtual string Nombre { get; set; }
        public virtual decimal Balance { get; set; }

        public override string ToString()
        {
            return this.IBAN;
        }
    }
}
