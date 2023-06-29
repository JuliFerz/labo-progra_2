namespace Entidades
{
    public class Ej
    {
        public static void Ejercicio_16()
        {
            Console.Title = "Ejercicio 16";

            Alumno alumnoUno = new Alumno("Mario", "Santos", 1354);
            Alumno alumnoDos = new Alumno("Emilio", "Ravenna", 4123);
            Alumno alumnoTres = new Alumno("Gabriel", "Medina", 2341);
            Alumno alumnoCuatro = new Alumno("Pablo", "Lamponne", 2413);

            alumnoUno.Estudiar(10, 10);
            alumnoDos.Estudiar(10, 9);
            alumnoTres.Estudiar(9, 8);
            alumnoCuatro.Estudiar(1, 1);

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
            Console.WriteLine(alumnoCuatro.Mostrar());
        }
        public static void Ejercicio_17()
        {
            Console.Title = "Ejercicio 17";

            string resultado;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            //boligrafoAzul.Pintar(59, out resultado);

            Console.ForegroundColor = boligrafoAzul.GetColor(); // cambia color letras consola
            boligrafoAzul.Pintar(10, out resultado);
            Console.WriteLine(resultado);
        }
    }
}
