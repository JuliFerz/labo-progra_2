using Entidades;
using System;

namespace clase_16
{
    internal class Program
    {
        /* OTRO CASO POR EL PROFESOR */
        // Metodo que devuelve un delegado
        static Func<string, string, string> Ejecutar(int cantidad)
        {
            Console.WriteLine("Me inicializo");
            string usuarioValido = "admin";
            string claveValida = "12345";
            int intentos = 0;

            return (usuario, clave) =>
            {
                Console.WriteLine("Me ejecuto");
                if (intentos < cantidad)
                {
                    if (usuario == usuarioValido && clave == claveValida)
                    {
                        return "Bienvenido admin";
                    }
                    intentos++;
                    return "Usuario o clave incorrecta";
                }
                Console.WriteLine("Ya no me ejecuto mas");
                return "Usuario bloqueado";
            };
        }


        //static void HacerAlgo(int a)
        static void HacerAlgo()
        {
            Console.WriteLine("Hola Mundo");
        }
        static string Saludar(int numero)
        {
            return "Hola mundo";
        }
        static bool Saludar2(string value)
        {
            return value == "Hola mundo";
        }
        static int FuncionCriterio(Persona personaA, Persona personaB)
        {
            return personaA.Edad - personaB.Edad;
        }
        // Para el delegado propio
        static void MetodoParaMiDelegado()
        {
            Console.WriteLine("Hola Mundo desde mi MetodoParaMiDelegado");
        }
        static void MetodoParaMiDelegado2()
        {
            Console.WriteLine("Hola Mundo desde mi MetodoParaMiDelegado LALALALA");
        }
        static void MetodoParaMiDelegado3()
        {
            Console.WriteLine("Hola Mundo desde mi MetodoParaMiDelegado ASASASAS");
        }
        static string MetodoParaMiNuevoDelegado()
        {
            return "Hola Mundo desde mi MetodoParaMiDelegado11111";
        }
        static string MetodoParaMiNuevoDelegado2()
        {
            return "Hola Mundo desde mi MetodoParaMiDelegado22222222";
        }
        static string MetodoParticular(string value, string value2)
        {
            return $"{value}, {value2}";
        }
    }
}