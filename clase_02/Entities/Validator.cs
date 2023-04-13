namespace Entities
{
    public class Validator
    {
        /// <summary>
        /// Función que valida un numero entre un rango específico
        /// </summary>
        /// <param name="mensaje">mensaje a imprimir por pantalla</param>
        /// <param name="valor">es el valor a retornar</param>
        /// <param name="min">es el minimo</param>
        /// <param name="max">es el maximo</param>
        public static void ValidarNumero(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine($"{mensaje}:");
            int.TryParse(Console.ReadLine(), out valor);

            while (valor < min || valor > max)
            {
                Console.WriteLine($"ERROR: {mensaje} nuevamente.\n\t(entre {min}-{max}):");
                int.TryParse(Console.ReadLine(), out valor);
            }
        }

        public static void ValidaTexto(string mensaje, out string valor, params string[] valores)
        {
            Console.WriteLine(mensaje);
            valor = Console.ReadLine();

            while (!valores.Contains(valor))
            {
                Console.WriteLine($"ERROR: ingrese un valor valido");
                valor = Console.ReadLine();
            }
        }
    }
}