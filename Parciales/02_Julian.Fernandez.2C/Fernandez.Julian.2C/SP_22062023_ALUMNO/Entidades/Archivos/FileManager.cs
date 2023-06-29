using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
    public static class FileManager
    {
        static string path;

        static FileManager()
        {
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\20230622_Fernandez_Julian_2C\\";
            FileManager.ValidaExistenciaDeDirectorio();
        }

        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            if (Path.GetExtension(nombreArchivo) == ".json" || Path.GetExtension(nombreArchivo) == ".txt")
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo, append))
                {
                    sw.WriteLine(data);
                }
            }
            else
            {
                throw new FileManagerException("Extensión no permitida");
            }
        }

        public static bool Serializar<T>(T elemento, string nombreArchivo)
            where T : class
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(elemento, options));
                }
                return true;
            }
            catch (FileManagerException ex)
            {
                FileManager.Guardar("Error al serializar", "logs.txt", true);
                throw new FileManagerException("Error al serializar");
            }
        }

        static void ValidaExistenciaDeDirectorio()
        {
            try
            {
                if (!Directory.Exists(FileManager.path))
                {
                    Directory.CreateDirectory(FileManager.path);
                }
            }
            catch (FileManagerException ex)
            {
                FileManager.Guardar($"Error al crear el directorio: {ex}", "logs.txt", true);
                throw new FileManagerException("Error al crear el directorio");
            }
        }
    }
}
