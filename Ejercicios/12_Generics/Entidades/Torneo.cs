using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        #region Atributos
        List<T> equipos;
        string nombre;
        #endregion

        #region Propiedades
        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                int max = this.equipos.Count;
                T equipoA;
                T equipoB;

                while (true)
                {
                    equipoA = this.equipos[r.Next(max)];
                    equipoB = this.equipos[r.Next(max)];
                    if (equipoA != equipoB)
                        break;
                }
                return CalcularPartido(equipoA, equipoB);
            }
        }
        #endregion

        #region Constructor
        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            return torneo.equipos.Contains(equipo);
        }
        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, Equipo equipo)
        {
            if ((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Append(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre del torneo: {this.nombre}");
            sb.Append($"Equipos: {string.Join(",", this.equipos)}");
            return sb.ToString();
        }
        private string CalcularPartido(T equipoA, T equipoB)
        {
            Random random = new Random();
            return $"[{equipoA.Nombre}][{random.Next(1, 101)}] - [{equipoB.Nombre}][{random.Next(1, 101)}]";
        }
    }
}