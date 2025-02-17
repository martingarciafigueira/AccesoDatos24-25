using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Vehiculo
    {
        public Vehiculo()
        {
        }

        public virtual int Id { get; set; }
        public virtual string Fabricante { get; set; }
        public virtual string Modelo { get; set; }
        public virtual int Anho { get; set; }
        public virtual string Tipo { get; set; }
        public virtual int? NumeroRuedas { get; set; }
        public virtual decimal? VelocidadMaxima { get; set; }

        public override string ToString()
        {
            return this.Fabricante + " " + this.Modelo + " " + this.Anho;
        }
    }
}
