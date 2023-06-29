using Entidades.Excepciones;
using System;
using System.Collections.Generic;
//using System.Linq; // Esto agrega metodos de extensión
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Conversor
    {

        public static string ConvertirANumeroRomano(int nro)
        {
            return Conversor.ConvertirUnidades(nro);
        }

        private static string ConvertirUnidades(int nro)
        {
            StringBuilder sb = new StringBuilder();
            if (nro > 0 && nro <= 3)
            {
                sb.Append('I', nro);
                return sb.ToString();
            }
            if (nro == 4) 
            {
                return "IV";
            }
            if (nro > 4 && nro < 9)
            {
                sb.Append("V");
                sb.Append('I', nro - 5);
                return sb.ToString();
            }
            if (nro == 9)
            {
                return "IX";
            }
            throw new NumeroInvalidoException("Numero inválido");
        }
    }
}
