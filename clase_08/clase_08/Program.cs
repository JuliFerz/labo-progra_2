using Entidades;

namespace clase_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi("ABC-123", "Fiat", 2, "QWERTY@1234");

            Console.WriteLine(taxi.Matricula);
            Console.WriteLine(taxi.Modelo);
            Console.WriteLine(taxi.Potencia);
            Console.WriteLine(taxi.Licencia);


            // LISKOV
            Vehiculo vehiculo = taxi; // Esta variable va a tener los datos de la instancia taxi
                                      // en vehículo pero no va a poder acceder a las cosas que
                                      // tiene la instancia taxi (metodos o propiedades específicas)
            Console.WriteLine(vehiculo.PonerEnMarcha());
            //Console.WriteLine(vehiculo.HacerCarrera()); // No se puede alcanzar, es un metodo de taxi, no vehiculo


            Autobus autobus = new Autobus("Matricula", "Modelo", 5, 30);
            List<Vehiculo>lista = new List<Vehiculo>();

            lista.Add(taxi); // puedo hacerlo porque taxi es de tipo vehículo
            lista.Add(autobus);

            foreach (Vehiculo v in lista)
            {
                if (v is Taxi taxi2) // preguntar si es de la instancia taxi (ya creamos una variable casteada)
                {
                    //Taxi taxi2 = (Taxi)v; // taxi2 lo estamos creando dentro del if (ya se está casteando ahí) 
                                          // lo tenemos que castear para poder acceder al metodo 
                                          // "hacerCarrera". Esto se debe hacer porque "v" es de tipo vehículo
                                          // O bien, la lista es de tipo vehículo

                    Console.WriteLine(taxi2.HacerCarrera()); // llamamos a metodo específico de la clase
                }
                else if (v is Autobus autobus2)
                {
                    Console.WriteLine(autobus2.HacerRecorrido()); // llamamos a metodo específico de la clase
                }
            }


        }
    }
}