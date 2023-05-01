using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Triangulo : Figura
    {
        private ConsoleColor color;
        public Triangulo(double yAltura, double xBase, ConsoleColor color)
            : base(yAltura, xBase)
        {
            this.color = color;
        }

        public override double Area { get { return this.CalcularArea(); } }
        //public abstract string algo { get; } // Esto NO es posible porque Triangulo NO es abstracto

        public ConsoleColor Color { get => color; }


        protected override double CalcularArea()
        {
            return (base.CalcularArea()) / 2;
        }

        public override string MostrarDatos()
        {
            return $"Soy un triangulo y mis datos son:{base.MostrarDatos()}";
        }

        public static bool operator ==(Triangulo a, Triangulo b)
        {
            return a.xBase == b.xBase && a.yAltura == b.yAltura;
        }

        public static bool operator !=(Triangulo a, Triangulo b)
        {
            return !(a == b);
        }

        /* SOBREESCRITURA DE METODOS OBJECT */

        /*
         * Sobreescribo el método solo en Triangulo.
         * ToString es un método de object que se puede usar en cualquier lado
         * Esta sobreescritura solamente afecta a Triangulo. Es decir, si hago ToString() dentro de la clase para una variable
         *  que tenga un entero, lo puedo usar normalmetne, porque no ´lo estoy haciendo sobre una variable de tipo Triangulo
         */
        // Si hicimos que los métodos de MostrarDatos estén en protected, viene bien hacer este override
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        // 20.26
        // Redefinir el Equals para no comparar por referencia (como lo hace por defecto),
        //  sino por la definición queyo quiera
        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Triangulo && ((Triangulo)obj) == this;
        }

        public override int GetHashCode()
        {
            return this.xBase.GetHashCode();
        }
    }
}
