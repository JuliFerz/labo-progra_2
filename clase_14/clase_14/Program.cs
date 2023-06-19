using Entidades;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Serialization;

namespace clase_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Absolute path
            // El arroba está porque la contrabarra sino rompe porque no lo reconoce como una secuencia válida
            //File.Create(@"D:\Users\julian\Documents\Julian\UTN\2. Segundo cuatrimestre\labo-progra_2\clase_14\miArchivo.txt");

            // Relative path
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            char separador = Path.DirectorySeparatorChar;
            string nombreCarpeta = "Archivos clase 14";
            string nombreArchivo = "miArchivo.txt";
            //ruta = $"{ruta}{separador}{nombreCarpeta}{separador}{nombreArchivo}"; // manual
            ruta = Path.Join(ruta, nombreCarpeta, nombreArchivo); // con Join();




            // Como en python. Para no abrir y cerrar el archivo, el uso de "using" ya abre y cierra el archivo
            // automáticamente en este bloque de código
            // Esto puede pisar TODO el archivo si es que el archivo ya tenía info dentro
            // El parametro booleano es si se va a appendear el texto (sin borrar la info que ya tenga), o no (lo sobreescribe entero)
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine("Hola mundo");
            }

            using (StreamReader sr = new StreamReader(ruta, true))
            {
                //string lecturaPorLinea = sr.ReadLine();
                string lectura = sr.ReadToEnd();
                Console.WriteLine(lectura);
            }*/


            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            char separador = Path.DirectorySeparatorChar;
            string nombreCarpeta = "Archivos clase 14";
            string nombreArchivo = "miObjeto.xml"; // para serializar en XML
            string rutaCompleta = Path.Join(ruta, nombreCarpeta, nombreArchivo); // con Join();


            Persona persona = new Persona("Julian", "Fernandez");
            // Serializar en XML
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                // Le indicamos a qué tipo queremos serializar porque necesita las propiedades/atributos
                // publicas del objeto
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xml.Serialize(sw, persona);
            }

            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona2 = (Persona)xml.Deserialize(sr);

                Console.WriteLine(persona2.Nombre);
                Console.WriteLine(persona2.Apellido);
            }


            // Serializar en JSON
            nombreArchivo = "miObjeto.json";
            rutaCompleta = Path.Join(ruta, nombreCarpeta, nombreArchivo);

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                // No se puede instanciar, es clase estática
                //JsonSerializer json = new JsonSerializer(typeof(Persona));
                string json = JsonSerializer.Serialize<Persona>(persona, opciones);
                Console.WriteLine(json);
                sw.WriteLine(json);

            }

            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                string json = sr.ReadToEnd();
                Persona persona3 = JsonSerializer.Deserialize<Persona>(json);
                Console.WriteLine("JSON");
                Console.WriteLine(persona3.Nombre);
                Console.WriteLine(persona3.Apellido);
            }
        }
    }
}