using Entidades.Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, short movimiento);
    public class Juego
    {
        public event InformacionDeAvance InformarAvance;
        private static short velocidad;
        private short ubicacion;
        private object controlVisual;

        public static short Velocidad { get => Juego.velocidad; set => Juego.velocidad = value; }
        public short Ubicacion { get => this.ubicacion; }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        public Juego(short ubicacion, object objetoVisual)
        {
            Juego.velocidad = 8;
            this.ubicacion = ubicacion;
            this.controlVisual = objetoVisual;
        }

        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel(CancellationToken cancellation)
        {
            do
            {
                this.InformarAvance.Invoke(this.controlVisual, Juego.velocidad);
                System.Threading.Thread.Sleep(60 + Juego.velocidad);
            } while (!cancellation.IsCancellationRequested);
        }

        public void SerializarJson(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                sw.WriteLine(JsonSerializer.Serialize<Juego>(this, options));
            }
        }
    }
}
