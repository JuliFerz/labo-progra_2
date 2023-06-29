using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        // Sobrecarga de constructor
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        // Constructor (llamo al constructor de arriba y le asigno 0)
        public Sumador() : this(0) { }

        // Sobrecarga de operador de conversión
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        // Sobrecarga de operador
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        // Metodos
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;

        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return $"{a} {b}";
        }
    }
}
