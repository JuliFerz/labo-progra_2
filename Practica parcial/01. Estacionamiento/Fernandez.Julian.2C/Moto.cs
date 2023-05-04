namespace Fernandez.Julian._2C
{
    public sealed class Moto : Vehiculo
    {
        

        #region Atributos
        public enum ETipo { Ciclomotor, Scooter, Sport }
        private ETipo tipo;
        private static double valorHora;
        #endregion

        #region Propiedades
        public override double CostoEstadia { get => this.CargoDeEstacionamiento(); }
        public override string Descripcion { get => this.tipo.ToString(); } // revisar si está medio medio
        public static double ValorHora { set { if(value > 0) Moto.valorHora = value; } }
        #endregion

        #region Constructor
        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método de instancia para calcular el cargo del estacionamiento de la moto
        /// </summary>
        /// <returns>dobule</returns>
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }

        /// <summary>
        /// Método de instancia para mostrar los datos de la moto
        /// </summary>
        /// <returns>string</returns>
        protected override string MostrarDatos()
        {
            return $"****MOTO*****\n De tipo: {this.Descripcion}\n {base.MostrarDatos()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}