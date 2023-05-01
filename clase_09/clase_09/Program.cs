using Entidades;

namespace clase_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura tr = new Triangulo(2, 3, ConsoleColor.Magenta);
            Figura rt = new Rectangulo(2, 3, ConsoleColor.Red);

            Console.WriteLine($"El área del triángulo es: {tr.Area}"); // sigo teniendo resultado porque la propiedad
                                                                       // Area se encuentra en la clase padre, y al mismo
                                                                       // tiempo las instancias pertenecen a Figura
            Console.WriteLine($"El área del rectangulo es: {rt.Area}");

            //Console.WriteLine(rt.MostrarDatos()); // Solo muestran los datos de base
            //Console.WriteLine(tr.MostrarDatos()); // Muestra el string de MostrarDatos() de Triangulo

            Console.WriteLine(tr.ToString());


        }
    }
}
