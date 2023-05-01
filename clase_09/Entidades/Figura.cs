using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Figura
    {
        protected double yAltura;
        protected double xBase;

        protected Figura(double yAltura, double xBase)
        {
            this.yAltura = yAltura;
            this.xBase = xBase;
        }

        // No tengo un atributo que sea Area (comienzo del objeto), sino lo creo acá para que sea computado
        // Si es abstracto NO lleva implementación, lleva la firma
        public abstract double Area { get ; }

        protected virtual double CalcularArea()
        {
            return this.xBase * this.yAltura;
        }

        public virtual string MostrarDatos()
        {
            return $"\n[Altura: {this.yAltura}]\n[Base:{this.xBase}]";
        }
    }
}