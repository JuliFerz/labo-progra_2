using Entidades.DataBase;
using Entidades.Enumerados;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
using System.Text;

namespace Entidades.Modelos
{
    public class Hamburguesa : IComestible
    {

        private static int costoBase;
        private bool esDoble;
        private double costo;
        private bool estado;
        private string imagen;
        List<EIngrediente> ingredientes;
        Random random;

        public bool Estado => this.estado;
        public string Imagen => this.imagen;
        public string Ticket => $"{this}\nTotal a pagar:{this.costo}";


        static Hamburguesa() => Hamburguesa.costoBase = 1500;
        public Hamburguesa() : this(false) { }
        public Hamburguesa(bool esDoble)
        {
            this.esDoble = esDoble;
            this.random = new Random();
        }
        

        private void AgregarIngredientes()
        {
            this.ingredientes = new List<EIngrediente>(this.random.IngredientesAleatorios());
        }

        public void IniciarPreparacion()
        {
            if (!this.estado)
            {
                DataBaseManager.GetImagenComida($"Hamburguesa_{this.random.Next(1, 9)}");
                this.AgregarIngredientes();
            }
        }
        public void FinalizarPreparacion(string cocinero)
        {
            this.costo = Hamburguesa.costoBase + this.ingredientes.CalcularCostoIngredientes(Hamburguesa.costoBase);
            this.estado = true;
        }

        private string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hamburguesa {(this.esDoble ? "Doble" : "Simple")}");
            stringBuilder.AppendLine("Ingredientes: ");
            this.ingredientes.ForEach(i => stringBuilder.AppendLine(i.ToString()));
            return stringBuilder.ToString();

        }

        public override string ToString() => this.MostrarDatos();

    }
}