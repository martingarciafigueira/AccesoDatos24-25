using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Clases
{
    public class Equipo
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int goles;
        private int puntos;
        private string pj;
        private int pg;
        private int pe;
        private int pp;
        private string estadio;
        private string ciudad;

        public Equipo()
        {
        }

        public Equipo(string codigo, string nombre, string pais, int goles, int puntos, string pj, int pg, int pe, int pp, string estadio, string ciudad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.pais = pais;
            this.goles = goles;
            this.puntos = puntos;
            this.pj = pj;
            this.pg = pg;
            this.pe = pe;
            this.pp = pp;
            this.estadio = estadio;
            this.ciudad = ciudad;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Pj { get => pj; set => pj = value; }
        public int Pg { get => pg; set => pg = value; }
        public int Pe { get => pe; set => pe = value; }
        public int Pp { get => pp; set => pp = value; }
        public string Estadio { get => estadio; set => estadio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
