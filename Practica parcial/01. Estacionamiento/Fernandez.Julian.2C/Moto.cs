namespace Fernandez.Julian._2C
{
    public sealed class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport }
        private ETipo tipo;
        private static double valorHora;

        public override double CostoEstadia { get => this.CargoDeEstacionamiento(); }
        public override string Descripcion { get => this.tipo.ToString(); } // revisar si está medio medio
        public static double ValorHora { set { if(value > 0) Moto.valorHora = value; } }

        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            return $"****MOTO*****\n De tipo: {this.Descripcion}\n {base.MostrarDatos()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}