namespace Fernandez.Julian._2C
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        public override double CostoEstadia { get => this.CargoDeEstacionamiento(); }
        public override string Descripcion { get => this.marca; }
        public static double ValorHora { set { if (value > 0) Automovil.valorHora = value; } }

        static Automovil()
        {
            Automovil.valorHora = 120;
        }
        public Automovil(string patente, DateTime horaIngreso, string marca)
            : base(patente, horaIngreso)
        {
            //this.Patente = patente;
            //this.HoraIngreso = horaIngreso;
            this.marca = marca;
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }
        protected override string MostrarDatos()
        {
            return $"****AUTOMOVIL*****\n Marca: {this.Descripcion}\n {base.MostrarDatos()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}