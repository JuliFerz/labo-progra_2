using Entidades;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = "12345678";
            alumnoUno.Nombre = "Juan";
            alumnoUno.Apellido = "Perez";

            Alumno alumnoDos = "12345678";
            Alumno alumnoTres = new Alumno(33333333, "L-33333333");
            Alumno alumnoCuatro = "44444444";
            Alumno alumnoCinco = "44444444";
            Alumno alumnoSeis = "55555555";



            Profesor proUno = new Profesor(12345, "profeUno@mail.com");

            proUno.Materia = EMateria.Laboratorio;
            proUno.Nombre = "Mario";
            proUno.Apellido = "Gonzalez";
            Console.WriteLine(proUno.Informacion);



            Profesor proDos = new Profesor(12345, "profeDos@mail.com");

            proDos.Materia = EMateria.Programacion;
            proDos.Nombre = "Juan";
            proDos.Apellido = "Perez";
            Console.WriteLine(proDos.Informacion);

            Curso cursoLabo = new Curso(proUno);
            Curso cursoProgra = new Curso(proDos);


            Console.WriteLine($"inscribo alumno Uno a labo con resultado:\n{cursoLabo.InscribirAlumno(alumnoUno)}");
            Test.Clean();

            Console.WriteLine($"inscribo alumno Dos a labo con resultado:\n{cursoLabo.InscribirAlumno(alumnoDos)}");
            Test.Clean();

            Console.WriteLine($"inscribo alumno Tres a labo resultado:\n{cursoLabo.InscribirAlumno(alumnoTres)}");
            Test.Clean();

            Console.WriteLine($"inscribo alumno Cuatro a labo resultado:\n{cursoLabo.InscribirAlumno(alumnoCuatro)}");
            Console.WriteLine($"inscribo alumno Cuatro a progra resultado:\n{cursoProgra.InscribirAlumno(alumnoCuatro)}");



            Test.Clean();
            Console.WriteLine($"inscribo alumno Cinco a labo resultado:\n{cursoLabo.InscribirAlumno(alumnoCinco)}");
            Console.WriteLine($"inscribo alumno Cinco a progra resultado:\n{cursoProgra.InscribirAlumno(alumnoCinco)}");


            Test.Clean();
            Console.WriteLine($"inscribo alumno Seis a progra resultado:\n{cursoProgra.InscribirAlumno(alumnoSeis)}");
            Console.WriteLine($"inscribo alumno Seis a labo resultado:\n{cursoLabo.InscribirAlumno(alumnoSeis)}");

            Test.Clean();
            Console.WriteLine("\n\n********************LABO**************************\n\n");

            Console.WriteLine(Curso.MostrarInformacionDelCurso(cursoLabo));

            Test.Clean();
            Console.WriteLine("\n\n********************PROGRA**************************\n\n");

            Console.WriteLine(Curso.MostrarInformacionDelCurso(cursoProgra));

            Curso.EvaluarAlumnos(cursoLabo);
            Curso.EvaluarAlumnos(cursoProgra);

        }

        public static void Clean()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}