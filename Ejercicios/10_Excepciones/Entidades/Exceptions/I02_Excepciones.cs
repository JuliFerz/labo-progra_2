﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string? message) : base(message)
        {
        }

        public ParametrosVaciosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
