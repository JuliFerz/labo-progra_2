using Entidades.Exceptions;
using System.Text.RegularExpressions;

namespace Entidades.Models
{
    public class Calculator
    {
        public static int Add(string numeros)
        {
            int resultado = 0;
            string pattern = GetPattern(numeros);
            if (!string.IsNullOrEmpty(numeros))
            {
                if (Regex.IsMatch(numeros, pattern))
                {
                    foreach (string str in Regex.Split(numeros, pattern))
                    {
                        int nro = str != "//" ? int.Parse(str) : 0;
                        if (nro < 0)
                            throw new CalculatorExceptions($"Error, hay un numero negativo ({nro})");
                        resultado += nro;
                    }
                }
                else
                {
                    resultado += int.Parse(numeros);
                }
            }
            return resultado;
        }

        public static string GetPattern(string numeros)
        {
            string? evaluate = numeros.Length > 3 && numeros[0..2] == "//" ? numeros[2].ToString() : null;
            return $@"[, {evaluate}]+";
        }
    }
}