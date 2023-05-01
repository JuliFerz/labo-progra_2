using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private ConsoleColor color;
        public Rectangulo(double yAltura, double xBase, ConsoleColor color)
            : base(yAltura, xBase)
        {
            this.color = color;
        }

        public override double Area { get { return this.CalcularArea(); } }

        public ConsoleColor Color { get => color; }

        protected override double CalcularArea()
        {
            return base.CalcularArea();
        }
    }
}
