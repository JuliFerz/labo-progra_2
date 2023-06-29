using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades.Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta { get => Environment.SpecialFolder.Desktop.ToString() + '\\'; }

        public bool ExisteArchivo(string nombreArchivo)
        {
            if (!Directory.Exists(this.GenerarRutaCompleta))
            {
                Directory.CreateDirectory(this.GenerarRutaCompleta);
            }
            else if (!File.Exists(this.GenerarRutaCompleta + nombreArchivo))
            {
                return false;
            }
            return true;
        }
        public void Guardar(string archivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.GenerarRutaCompleta + archivo, true))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(objeto, options));
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("No se pudo guardar el archivo", ex);
            }
        }
        public void Leer(string archivo, out T objeto)
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.GenerarRutaCompleta + archivo))
                {
                    string json = sr.ReadToEnd();
                    objeto = JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("No se pudo leer el archivo", ex);
            }
        }
    }
}
