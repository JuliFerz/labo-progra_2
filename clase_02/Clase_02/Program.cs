using Entities;

namespace Clase_02
{
    internal class Program
    {
        /*
         * Nombre de la mascota
         * Edad (Validar 1 - 12)
         * Tipo: (Validar “gato”, “perro”, “hamster”)
         * Peso: (Validar 0 - 50)
         * Diagnostico: (Validar  “otitis”, “alergias”)
         * 
         * Informes:
         * 
         * Nombre de la mascota más vieja
         * Cantidad de mascotas con parásitos
         * Nombre, edad y diagnóstico de la mascota más joven ingresada.
         */
        static void Main(string[] args)
        {
            string nombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota; // Por cuestión didáctica se hace entero
            string diagnosticoMascota;

            Console.WriteLine("Ingrese el nombre de la mascota:");
            nombreMascota = Console.ReadLine();

            // Llamar funcion
            // Entities.Validator.ValidarNumero("Ingrese la edad de la mascota (1 - 12)", out edadMascota, 1, 12);
            Validator.ValidarNumero("Ingrese la edad de la mascota (1 - 12)", out edadMascota, 1, 12);
            Validator.ValidaTexto("Ingrese el tipo de mascota(“gato”, “perro”, “hamster”)", out tipoMascota, "gato", "perro", "hamster");
            Validator.ValidarNumero("Ingrese el peso de la mascota (0 - 50)", out pesoMascota, 0, 50);
            Validator.ValidaTexto("Ingrese el diagnóstico (“otitis”, “alergias”, “parasitos”)", out diagnosticoMascota, "otitis", "alergias", "parasitos");

            Console.WriteLine(edadMascota);
            Console.WriteLine(diagnosticoMascota);
            Console.WriteLine(pesoMascota);
            Console.WriteLine(tipoMascota);


            // tipo de retorno: void; nombre de función: Validar numero; parametros: son 3
            // 2: tipo de retorno: int; Tipo de salida: out (paso referencia de variable) int (de tipo int) valor (se asigna en la variable valor)
            /*void ValidarNumero(string mensaje, out int valor, int min, int max)
            {
                Console.WriteLine($"{mensaje}:");
                int.TryParse(Console.ReadLine(), out valor);
                while (valor < min || valor > max)
                {
                    Console.WriteLine($"ERROR: {mensaje} nuevamente.\n\t(entre {min}-{max}):");
                    int.TryParse(Console.ReadLine(), out valor);
                }
            }*/

            /*void ValidaTexto(string mensaje, out string valor, params string[] valores)
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine();

                while (!valores.Contains(valor))
                {
                    Console.WriteLine($"ERROR: ingrese un valor valido");
                    valor = Console.ReadLine();
                }
            }*/

        }
    }
}