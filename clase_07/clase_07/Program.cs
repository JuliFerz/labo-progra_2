using Entidades;

namespace clase_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("12345678", "Fernandez", ETipo.ALUMNO);
            // NOTA:
            // Si el Enumerado pertenece a la clase (no está en el namespace, sino que en la clase Persona),
            // la línea anterior me tiraría error. Para corregirlo debería hacer:
            // Persona p = new Persona("12345678", "Fernandez", Persona.ETipo.ALUMNO);


            //p.dni = -909294; // NO queremos permitir que se modifique
            //Console.WriteLine(p.dni); // DNI es privado, por ende no puedo acceder al dato

            // ******* ante, SIN getter/setter:
            //p.SetDni(-999999); // No cambia a este valor por el if del método SetDni
            //Console.WriteLine(p.GetDni());
            //p.SetFechaNacimiento(new DateTime(2000, 11, 18));
            //Console.WriteLine(p.GetEdad());
            //Console.WriteLine(p.GetApellido());


            // Ahora con getter/setter
            //p.Dni = 333333;
            //Console.WriteLine(p.Dni);


            string value = p["apellidoo"];
            Console.WriteLine(value);

        }
    }
}