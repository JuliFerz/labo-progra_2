using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraMultiuso
    {
        List<IAcciones> listaAcc;

        public CartucheraMultiuso(List<IAcciones> lista)
        {
            this.listaAcc = lista;
        }

        public bool RecorrerElementos()
        {
            foreach (var item in listaAcc)
            {
                item.UnidadesDeEscritura--;
            }
            listaAcc.ForEach(item => item.Recargar(20));
            return true;
        }
    }
}
