using Entidades.Interfaces;
using Entidades.Modelos;

namespace clase_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IMensaje> carteros = new List<IMensaje>();
            Paloma paloma = new Paloma();
            Cartero cartero = new Cartero();

            IMensaje mensajeador = new Paloma();
            IMensaje mensajeador2 = new Whatsapp();
            IMensaje mensajeador3 = new Cartero();
            IMensaje mensajeador4 = new Email();
            /*
             * Esto posible (que IMensaje pueda contener una instancia de clases diferentes) 
             * porque todas estas clases, a nivel de herencia NO hay relación entre sí,
             * pero sí tienen la MISMA implementación de interface
             */


            //((Cartero)mensajeador3).Nombre = "TEST"; // Ejemplo de si quiero acceder a la propiedad nombre de cartero
            /*
             *  Si quiero acceder a una propiedad de cartero 
             *  (que no pertenece a la interface, podemos castear
             *  el IMensaje a Cartero para acceder a ella)
             */


            carteros.Add(cartero);
            carteros.Add(paloma);
            /*
             * Me permite agregar paloma a carteros porque cada elemento de la lista es de tipo IMensaje, por ende
             * cartero y paloma comparten la misma implementación. Al mismo tiempo, comparten la misma forma
             * polimorfica, es decir, se los puede loopear sin tener que castear:
             */

            foreach (IMensaje item in carteros)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            //Console.WriteLine(cartero.EnviarMensaje());
            //Console.WriteLine(paloma.EnviarMensaje());
        }
    }
}