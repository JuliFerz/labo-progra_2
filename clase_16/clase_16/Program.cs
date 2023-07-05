using Entidades;
using System;

namespace clase_16
{
    internal class Program
    {
        /******** Generar PROPIO delegado ********/
        //public delegate int MiDelegado(string value);
        public delegate void MiDelegado();
        public delegate string MiDelegado2();
        public delegate string MiDelegado3(string value1, string value2);

        static void Main(string[] args)
        {
            /* USAR DELEGADOS PROPIOS */
            MiDelegado miDelegado = MetodoParaMiDelegado; // no se pone parentesis porque no estamos invocando, estamos guardando la referencia
            // MiDelegado miDelegado = new MiDelegado(MetodoParaMiDelegado); // otra forma de hacerlo
            // miDelegado2 += MetodoParaMiDelegado2;
            MiDelegado2 miDelegado2 = MetodoParaMiNuevoDelegado;
            MiDelegado3 miDelegado3 = MetodoParticular;
            // Para miDelegado3, es lo mismo que hacer:
            // Func<string,string,string> miDelegado = MetodoParticular;

            miDelegado += MetodoParaMiDelegado2;
            miDelegado += MetodoParaMiDelegado2; // Si lo guardo dos veces, se ejecuta dos veces 
            miDelegado += MetodoParaMiDelegado3;
            //miDelegado -= MetodoParaMiDelegado2; // Quito la referencia de este metodo (si est� dos veces, solo quito uno)
            //miDelegado = MetodoParaMiDelegado2;  // Reemplazo por completo el delegado (quita todas las referencias que tenga previamente)
            // y le deja solo MetodoParaMiDelegado2

            miDelegado2 += MetodoParaMiNuevoDelegado2;
            /* IMPORTANTE: Si hacemos algo as�, se PISA el RESULTADO y queda el ULTIMO METODO que se GUARDO en el DELEGADO */
            /*
             * string result = miDelegado2();
             * Console.WriteLine(result); // "Hola Mundo desde mi MetodoParaMiDelegado22222222"
             */

            /* Para delegados que retornan algo, se debe loopear */
            //foreach (MiDelegado2 d in miDelegado2.GetInvocationList())
            //{
            //    string algo = d();
            //    Console.WriteLine(algo);
            //}

            //miDelegado(); // ejecuta los tres m�todos (el 1, el 2 y el 3)

            //string result = miDelegado3("Hola", "mundo!");
            //Console.WriteLine(result);

            //Console.ReadKey();






            // Tipos de delegados PREDEFINIDOS
            /******** Action *********/
            /*
             * Metodo que NO retorna nada y tienen entre 0 y 16 parametros de entrada
             */
            Action delegado = HacerAlgo; // Necesita que la firma del m�todo sea compatible
                                         // Si el m�todo recibe un par�metro, esto no es valido, sino habr�a que hacer:
                                         // Action<int> delegado = HacerAlgo;


            /******** Func ********/
            /*
             * Retorna un tipo gen�rico y tienen entre 0 y 16 parametros de entrada
             * (el �ltimo gen�rico declarado (string en este caso) es el tipo de valor que retorna
             */
            Func<int, string> delegadoFunc = Saludar;


            /******** Predicate ********/
            /*
             * Recibe solo un parametro gen�rico y debe devolver un booleano
             */
            Predicate<string> delegadoPredicate = Saludar2;


            /******** Comparison ********/
            /*
             * Recibe dos gen�ricos, debe devolver un entero
             */
            //Comparison<Persona> delegadoComparison = FuncionCriterio;







            /* USO DE FUNCION CRITERIO CON SORT */ /* +FUNCION LAMBDA+ */
            Action action = () => { Console.WriteLine("Hola mundo desde mi funci�n lambda"); }; // Funci�n lambda que NO recibe parametro
            Comparison<Persona> delegadoComparison = (p1, p2) => p1.Edad - p2.Edad; // Delegado con funcion lambda
            List<Persona> lista = new List<Persona>()
            {
                new Persona("Pepe", 50),
                new Persona("Raul", 44),
                new Persona("Lucas", 52)
            };

            //lista.Sort(); // As� falla porque no puede comparar dos objetos.
            //Se corrige pasandole un comparison
            //lista.Sort(delegadoComparison); // va a ordenar por edad (menor a mayor)
            lista.Sort((p1, p2) => p1.Edad - p2.Edad); // Lo mismo pero directamente aplicando la F. lambda ac�
            Persona p = lista.Find((p) => p.Edad == 50);

            bool result = lista.Exists(p => p.Nombre == "Lucas");


            //action.Invoke(); // "Hola mundo desde mi funci�n lambda"

            //Console.WriteLine(p.ToString()); // Pepe, 50 a�os de edad.
            //Console.WriteLine(result); // true

            //foreach (Persona persona in lista)
            //{
            //    Console.WriteLine(persona.ToString()); // Raul, 44 a�os; Pepe, 50 a�os; Lucas, 52 a�os
            //}

            Func<int, double> CalcularPotenciaAlCuadrado = (numero) => numero * numero; // OTro delegado con funci�n lambda
            //Console.WriteLine(CalcularPotenciaAlCuadrado(3));



            //Func<string, string, bool> ejemplo = (val1, val2) => val1 == val2;
            //Func<string, string, bool> ejemplo = (val1, val2) => { return val1 == val2; };






            /* OTRO CASO POR EL PROFESOR */
            Func<string, string, string> login = Ejecutar(3); // Me inicializo
            Console.WriteLine(login("pepe", "1234")); // "Usuario o clave incorrecta"
            Console.WriteLine(login("pepe", "1234")); // "Usuario o clave incorrecta"
            Console.WriteLine(login("pepe", "1234")); // "Usuario o clave incorrecta"
            Console.WriteLine(login("pepe", "1234")); // "Usuario bloqueado"
        }

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