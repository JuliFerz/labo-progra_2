﻿using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Email : IMensaje
    {
        private bool estado;
        public bool Estado => throw new NotImplementedException();

        public string EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El email envía un mensaje";
        }
    }
}