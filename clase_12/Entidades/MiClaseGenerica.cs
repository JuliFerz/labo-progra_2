namespace Entidades
{
    //public class MiClaseGenerica
    //public class MiClaseGenerica<T, U> 
    //where T : U
    //where U : class
    public class MiClaseGenerica<T> where T : Persona
    {
        public void ImprimirValor<T>(T generico)
        {
            Console.WriteLine(generico);
        }
    }
}