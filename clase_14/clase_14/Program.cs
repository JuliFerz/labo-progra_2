using Entidades;
using System.Reflection.Emit;
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
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // string con la ruta hasta escritorio
            //char separador = Path.DirectorySeparatorChar; // caracter separador del path
            string nombreCarpeta = "carpeta_test";
            string nombreArchivo = "test.txt";
            //ruta = $"{ruta}{separador}{nombreCarpeta}{separador}{nombreArchivo}"; // manual
            //ruta = Path.Join(ruta, nombreCarpeta, nombreArchivo); // con Join(); (no hace falta el separador)
            *//* 
             * Lo dejo comentado porque lo uso más abajo para consultar si la ruta existe 
             * (para crear SOLO con el directorio), porque sino se crea el test.txt como si fuera un directorio 
             *//*


            ruta = Path.Join(ruta, nombreCarpeta);
            if (!Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);
            ruta = Path.Join(ruta, nombreArchivo);

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
            string nombreCarpeta = "carpeta_test";
            string nombreArchivo = "miObjeto.xml"; // para serializar en XML
            string rutaCompleta = Path.Join(ruta, nombreCarpeta, nombreArchivo); // con Join();


            Persona persona = new Persona("Julian", "Fernandez", 23);
            // ******************** Serializar en XML ******************** //
            /*using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                // Le indicamos qué tipo de objeto queremos serializar porque necesita las propiedades/atributos
                // publicas del objeto
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xml.Serialize(sw, persona); // serializa el objeto en formato XML
            }*/

            // ******************** Deserializar XML ******************** //
            /*using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                XmlSerializer? xml = new XmlSerializer(typeof(Persona));
                Persona persona2 = (Persona)xml.Deserialize(sr);

                Console.WriteLine($"{persona2.Apellido}, {persona2.Nombre}. {persona2.Edad} años");
            }*/


            // ******************** Serializar en JSON ******************** //
            nombreArchivo = "miObjeto.json";
            rutaCompleta = Path.Join(ruta, nombreCarpeta, nombreArchivo);

            /*using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true; // establecer que se indente
                // No se puede instanciar, es clase estática
                //JsonSerializer json = new JsonSerializer(typeof(Persona));
                string json = JsonSerializer.Serialize<Persona>(persona, opciones);
                Console.WriteLine(json);
                sw.WriteLine(json);

            }*/

            // ******************** Deserializar en JSON ******************** //
            /*using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                string json = sr.ReadToEnd();
                Persona persona3 = JsonSerializer.Deserialize<Persona>(json);
                Console.WriteLine($"{persona3.Apellido}, {persona3.Nombre}. {persona3.Edad} años");
            }*/

            // ******************** Serializar en TXT (archivo plano) ******************** //
            //nombreArchivo = "miObjeto.txt";
            //rutaCompleta = Path.Join(ruta, nombreCarpeta, nombreArchivo);

            //using (StreamWriter sw = new StreamWriter(rutaCompleta))
            //{
            //    sw.WriteLine(JsonSerializer.Serialize(persona));
            //}
        }
    }
}