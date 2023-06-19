using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // esta es la firma que debe tener el método que lo maneje
    public delegate void EnviarMensaje(string mensaje);
    public class Mensaje
    {
        public event EnviarMensaje OnMensaje;


        public void Saludar()
        {
            // generar una notificación a traves del llamado a este evento
            //this.OnMensaje("Hola Mundo"); // es lo mismo sin invoke

            if (OnMensaje != null)
            {
                this.OnMensaje.Invoke("Hola Mundo");
            }
        }
    }
}
