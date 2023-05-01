using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto { Caja1, Caja2 }
        private static int numeroActual;
        private EPuesto puesto;

        public static int NumeroActual
        {
            get { return PuestoAtencion.numeroActual++; }
        }

        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {

        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(10000);
            return false;
        }
    }
}