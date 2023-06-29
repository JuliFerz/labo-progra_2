using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class CalculatorExceptions : Exception
    {
        public CalculatorExceptions(string? message) : base(message)
        {
        }

        public CalculatorExceptions(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
