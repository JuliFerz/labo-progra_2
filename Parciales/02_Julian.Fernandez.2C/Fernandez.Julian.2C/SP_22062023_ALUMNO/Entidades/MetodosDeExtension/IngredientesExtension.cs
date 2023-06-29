using Entidades.Enumerados;


namespace Entidades.MetodosDeExtension
{
    public static class IngredientesExtension
    {
        public static double CalcularCostoIngredientes(this List<EIngrediente> ingredientes, int costoInicial)
        {
            double costoTotal = costoInicial;
            foreach (EIngrediente ingrediente in ingredientes)
            {
                double porcentaje = (costoTotal * (int)ingrediente) / 100;
                costoTotal += porcentaje;
            }
            return costoTotal;
        }

        public static List<EIngrediente> IngredientesAleatorios(this Random random)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>()
            {
                EIngrediente.QUESO,
                EIngrediente.PANCETA,
                EIngrediente.ADHERESO,
                EIngrediente.HUEVO,
                EIngrediente.JAMON,
            };
            return ingredientes.Take(random.Next(1, ingredientes.Count + 1)).ToList();
        }
    }
}
