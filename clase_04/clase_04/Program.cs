using Ejercicio_l02;
using Entidades;

namespace clase_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(2, 3));
            Console.WriteLine(calculadora.Sumar(2, 3, 4));

            string[] materias = { "matematica", "estadística" };

            Alumno alumno = new Alumno(1, "Pepe", "Ferrini", materias);
            Alumno alumno2 = new Alumno(1, "Pepe", "Ferrini", materias);

            Console.Write(alumno == alumno2); // true
            // Aclaración, si comparo dos instancias que NO tienen la funcion operator ==
            // compara por referencia (va a dar siempre false)


            int numero = 10;
            double numero2 = 1.5;
            // para asignar, se corrije así:
            // numero = (int)numero2; // explicito (asume SI hay perdida de datos)
            // numero2 = numero; // implicito (asume NO hay perdida de datos)

            string nombreCompleto = alumno; // implicita
            int legajo = (int)alumno; // explicita

            Console.WriteLine(nombreCompleto);
            Console.WriteLine(legajo);



            // ------- ejemplo persona
            Persona p = 1111;
            Console.WriteLine($"DNI persona: {p.GetDni()}");
        }
    }
}