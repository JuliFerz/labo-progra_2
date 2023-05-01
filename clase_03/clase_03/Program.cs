using Entidades;

namespace clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
             *  -> SIN CONSTRUCTOR <-
             * Persona personaUno = new Persona(); // Instanciamos un objeto
             *          * -> ACLARACIÓN:
             *              Si existe un contructor en el objeto Persona, esta línea tiraría error porque 
             *              la clase persona tiene un constructor que toma valores. Si quiero una clase 
             *              que no tire error, debo crear un constructor que no reciba parametros.
             * 
             * // Asignamos los valores manualmente
             * personaUno.nombre = "Julian"; 
             * personaUno.apellido = "Fernandez";
             * personaUno.edad = 22;
             */

            /*
             *  -> CON CONSTRUCTOR <-
             * Persona personaUno = new Persona("Julian", "Fernandez");
             * 
             * // O se puede hacer también:
             * Persona personaUno = new Persona(nombre: "Julian", apellido:"Fernandez");
             * 
             * Console.WriteLine(personaUno.nombre);
             *              -> Devuelve 0 porque el constructor no recibe edad, 
             *                  ni tampoco se asignó un valor.
             */

            Persona personaUno = new Persona("Julian", "Fernandez");
            //personaUno.nombre = "Julian";
            //personaUno.apellido = "Fernandez";
            //personaUno.edad = 22;

            Console.WriteLine(personaUno.edad); // devuelve 0 si se mantiene comentada la línea 19;

            // Console.WriteLine(Persona.familia); // si se puede
            //Console.WriteLine(Persona.familia); // mono
            //personaUno.CambiarFamilia("LALAL");
            //Console.WriteLine(Persona.familia); // LALAL

            // Console.WriteLine(personaUno.familida);// no se puede

           /*
            Perro miPerro = new Perro();
            miPerro.duenio = personaUno;
            miPerro.edad = 2;
            miPerro.nombre = "Bobby";

            Perro miPerroDos = new Perro();
            miPerroDos.duenio = personaUno;
            miPerroDos.edad = 1;
            miPerroDos.nombre = "Pucchi";

            Console.WriteLine(miPerro.Saludar()); // Guau guau! mi nombre es Bobby


            Perro perroReferencia = miPerroDos;
            //Console.WriteLine(miPerroDos.Saludar()); // Guau guau! mi nombre es Pucchi
            perroReferencia.nombre = "Pipi"; // El nombre cambia en perroReferencia y también en perroDos (porque tienen misma ref)
                                             //Console.WriteLine(miPerroDos.Saludar()); // Guau guau! mi nombre es Pipi

            // Nombre del dueño del perro
            //Console.WriteLine(miPerro.duenio.nombre);
            */



        }
    }
}