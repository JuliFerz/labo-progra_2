using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraSimple
    {
        List<Boligrafo> listaBoligrafos;
        List<Lapiz> listaLapices;

        public bool RecorrerElementos()
        {
            foreach (var item in listaBoligrafos)
            {
                item.UnidadesDeEscritura--;
            }
            foreach (var item in listaLapices)
            {
                item.UnidadesDeEscritura--;
            }
            listaBoligrafos.ForEach(item => item.Recargar(20));
            return true;
        }
    }
}
