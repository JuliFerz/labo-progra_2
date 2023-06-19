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

            IMensaje mensajeador = new Paloma();    // Es posible porque todas estas clases, a nivel de herencia
                                                    // NO hay relación entre sí, pero sí tienen la MISMA implementación
                                                    // de interface
            IMensaje mensajeador2 = new Whatsapp();
            IMensaje mensajeador3 = new Cartero();
            IMensaje mensajeador4 = new Email();


            //((Cartero)mensajeador3).Nombre = "TEST"; // Si quiero acceder a una propiedad de cartero
                                                       //(que no pertenece a la interface, podemos castear
                                                       // el IMensaje a Cartero para acceder a ella)
            

            carteros.Add(cartero);
            carteros.Add(paloma); // me permite agregar paloma a carteros porque la lista es de IMensaje, por ende
                                  // comparten la misma implementación. Al mismo tiempo, comparten la misma forma
                                  // polimorfica, es decir, se los puede loopear sin tener que castear:
        
            foreach (IMensaje item in carteros)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            //Console.WriteLine(cartero.EnviarMensaje());
            //Console.WriteLine(paloma.EnviarMensaje());
        }
    }
}