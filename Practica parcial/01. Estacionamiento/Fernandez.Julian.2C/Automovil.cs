namespace Fernandez.Julian._2C
{
    public sealed class Automovil : Vehiculo
    {
        #region Atributos
        private string marca;
        private static double valorHora;
        #endregion

        #region Propiedades
        public override double CostoEstadia { get => this.CargoDeEstacionamiento(); }
        public override string Descripcion { get => this.marca; }
        public static double ValorHora { set { if (value > 0) Automovil.valorHora = value; } }
        #endregion

        #region Constructor
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
        #endregion

        #region Metodos
        /// <summary>
        /// Método de instancia para calcular el cargo del estacionamiento del automovil
        /// </summary>
        /// <returns>dobule</returns>
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }

        /// <summary>
        /// Método de instancia para mostrar los datos del automovil
        /// </summary>
        /// <returns>string</returns>
        protected override string MostrarDatos()
        {
            return $"****AUTOMOVIL*****\n Marca: {this.Descripcion}\n {base.MostrarDatos()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}