namespace Ejercicio_36
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        public enum ETipoCompetencia { F1, MotoCross }
        private ETipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random random = new Random();
            if (c.cantidadCompetidores > c.competidores.Count && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)random.Next(15, 100);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c.competidores.Count > 0 && c == a)
            {
                a.EnCompetencia = false; // esta de más porque lo estoy sacando
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            // Otra manera para comparar los tipos
            //if (c.tipo == Competencia.ETipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) { }

            if (c.tipo == ETipoCompetencia.F1 && a is not AutoF1 || 
                c.tipo == ETipoCompetencia.MotoCross && a is not MotoCross)
            {
                foreach (VehiculoDeCarrera v in c.competidores)
                {
                    if (v == a) { return true; }
                }
            }

            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public string MostrarDatos()
        {
            return $"Cantidad de vueltas de la competencia: {this.cantidadVueltas}\nCant. competidores: {this.cantidadCompetidores}";
        }
    }
}