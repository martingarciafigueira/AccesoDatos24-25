using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Clases
{
    public class Futbolista
    {
        private string codigo;
        private string nombre;
        private string codigoEquipo;
        private string posicion;
        private int edad;
        private int goles;
        private int ta;
        private int tr;
        private int minutos;
        private string precioMercado;
        private int dorsal;
        private int peso;

        public Futbolista()
        {
        }

        public Futbolista(string codigo, string nombre, string codigoEquipo, string posicion, int edad, int goles, int ta, int tr, int minutos, string precioMercado, int dorsal, int peso)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.CodigoEquipo = codigoEquipo;
            this.Posicion = posicion;
            this.Edad = edad;
            this.Goles = goles;
            this.Ta = ta;
            this.Tr = tr;
            this.Minutos = minutos;
            this.PrecioMercado = precioMercado;
            this.Dorsal = dorsal;
            this.Peso = peso;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CodigoEquipo { get => codigoEquipo; set => codigoEquipo = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Ta { get => ta; set => ta = value; }
        public int Tr { get => tr; set => tr = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public string PrecioMercado { get => precioMercado; set => precioMercado = value; }
        public int Dorsal { get => dorsal; set => dorsal = value; }
        public int Peso { get => peso; set => peso = value; }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
