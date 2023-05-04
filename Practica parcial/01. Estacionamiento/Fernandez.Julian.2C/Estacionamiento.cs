using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernandez.Julian._2C
{
    public class Estacionamiento
    {
        #region Atributos
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private int capacidadEstacionamiento;
        private string nombre;
        #endregion

        #region Propiedades
        public List<Vehiculo> ListadoVehiculos { get => this.listadoVehiculos; }
        public string Nombre { get => this.nombre; }
        #endregion

        #region Constructor
        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Método para generar una instancia de estacionamiento en caso de no existir uno creado.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="capacidad"></param>
        /// <returns></returns>
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        /// <summary>
        /// Método para informar los datos del vehículo antes de su salida (antes de eliminar registro en lista)
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nNombre: {estacionamiento.Nombre}");
            sb.Append($"\nDatos del vehículo: {vehiculo.ToString()}");
            sb.Append($"\nHora de salida: {vehiculo.HoraEgreso}");
            sb.Append($"\n{vehiculo.CostoEstadia}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga operadores
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return estacionamiento.ListadoVehiculos.Contains(vehiculo) ? true : false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento e, Vehiculo vehiculo)
        {
            bool result = false;
            if (e.listadoVehiculos.Count < e.capacidadEstacionamiento &&
                !e.ListadoVehiculos.Contains(vehiculo))
            {
                result = true;
                e.ListadoVehiculos.Add(vehiculo);
            }
            return result;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool result = false;
            if (estacionamiento.ListadoVehiculos.Contains(vehiculo))
            {
                result = true;
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.ListadoVehiculos.Remove(vehiculo);
            }
            return result;
        }
        #endregion
    }
}
