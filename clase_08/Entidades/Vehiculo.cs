namespace Entidades
{
    public class Vehiculo
    {
        //private string matricula; // no se puede acceder en sub clases porque es privado
        protected string matricula; // protected permite accederse desde sus sub clases
        protected string modelo;
        protected double potencia;

        public Vehiculo(string matricula, string modelo, double potencia)
        {
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Potencia = potencia;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Potencia { get => potencia; set => potencia = value; }

        public string PonerEnMarcha()
        {
            return "Arrancando...";
        }
    }
}