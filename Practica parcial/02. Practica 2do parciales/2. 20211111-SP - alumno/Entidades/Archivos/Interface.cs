using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta { get; }

        public bool ExisteArchivo(string nombreArchivo);
        public void Guardar(string archivo, T objeto);
        public void Leer(string archivo, out T objeto);
    }
}
