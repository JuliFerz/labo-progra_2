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

        static PuestoAtencion() // es "constructor de clase"
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Cliente atendido: {cli.Nombre}");
            return true;
        }
    }
}