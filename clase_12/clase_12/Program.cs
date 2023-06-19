using Entidades;

namespace clase_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MiClaseGenerica<int> miClaseGenerica = new MiClaseGenerica<int>();
            //MiClaseGenerica<string> miClaseGenericaTexto = new MiClaseGenerica<string>();
            //miClaseGenerica.ImprimirValor(10); // Se especifica el tipo para bvuenas practicas
            //miClaseGenericaTexto.ImprimirValor("qwerty"); // Se especifica el tipo para bvuenas practicas

            //MiClaseGenerica miClaseGenerica = new MiClaseGenerica();
            //MiClaseGenerica miClaseGenericaTexto = new MiClaseGenerica();
            //miClaseGenerica.ImprimirValor<int>(10); // Se especifica el tipo para bvuenas practicas
            //miClaseGenericaTexto.ImprimirValor<string>("qwerty"); // Se especifica el tipo para bvuenas practicas


            MiClaseGenerica<Persona> miClaseGenerica = new MiClaseGenerica<Persona>();
            MiClaseGenerica<Persona> miClaseGenericaTexto = new MiClaseGenerica<Persona>();
            MiClaseGenerica<Animal> miClaseGenericaTexto2 = new MiClaseGenerica<Animal>();


        }
    }
}
