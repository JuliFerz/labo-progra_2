﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class ArgumentoInvalidoException : Exception
    {

        public ArgumentoInvalidoException(string? message) : base(message)
        {
        }

        public ArgumentoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
