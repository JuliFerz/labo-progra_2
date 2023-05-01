using System.Text.RegularExpressions;

namespace Entidades
{
    public class Persona
    {
        // Atributos de clase
        private List<int> notas;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;

        // ENUMERADO E+Nombre
        //public enum EError { INVALIDO, MAYOR_CERO, IS_NULL };

        // por defecto es PUBLICA
        //public enum ETipo // despues va a ser reemplazado por herencia
        //{
        //    ALUMNO,     // si no se asigna valor, vale: 0
        //    PROFESOR    // si no se asigna valor, vale: 1
        //};

        // La instancia del enumerado PRIVADA
        private ETipo tipo;



        public Persona(string dni, string apellido, ETipo tipo)
        {
            //this.SetDni(dni);
            this.Dni = dni;
            //this.SetApellido(apellido);
            this.Apellido = apellido;
            this.tipo = tipo;
            this.notas = new List<int>();
        }

        //Si este método está comentado (estando como public), doy la posibilidad de lectura, pero no escritura
        //private void SetDni(int dni)
        //{
        //    if (dni > 0) { this.dni = dni; }
        //}

        // Se reemplaza por el setter
        //private void SetApellido(string apellido)
        //{
        //    if (this.ValidarNombreYApellido(apellido))
        //    {
        //        this.apellido = apellido;
        //    }
        //}

        // Se reemplaza por el setter
        //public void SetFechaNacimiento(DateTime fechaDeNacimiendo)
        //{
        //    this.fechaDeNacimiento = fechaDeNacimiendo;
        //}
        private bool ValidarNombreYApellido(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
        private bool ValidaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return fechaInicio < fechaFin;
        }


        // Metodo anterior:
        //public string GetApellido() { return this.apellido; }
        //public int GetDni() { return this.dni; }
        //public int GetEdad() { return DateTime.Now.Year - this.fechaDeNacimiento.Year; }



        // Ahora con getter/setter:
        public string Dni // no poner el mismo nombre "dni" (con minuscula) porque sino puedo generar un stackoverflow
        {
            get
            {
                return this.dni.ToString();
            }
            // Si comentamos el setter, la propiedad se hace de solo lectura
            // También se le puede hacer privado el setter (sigue siendo oculto para clases externas, 
            // pero no dentro del objeto.
            private set
            {
                Regex regexDni = new Regex("^[0-9]{8}$");
                // if (Regex.IsMatch(value, @"^[0-9]{8}$")) // Sin variable para la expresión REGEX
                if (regexDni.IsMatch(value)) // Usar variable para la expresión REGEX
                {
                    int.TryParse(value, out this.dni);

                }
            }
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (this.ValidarNombreYApellido(value)) { this.apellido = value; }
            }
        }
        // creamos un atributo que no existe en la creación de los atributos anteriores
        public int Edad
        {
            get { return DateTime.Now.Year - this.fechaDeNacimiento.Year; }
        }
        public DateTime FechaDeNacimiento
        {
            set
            {
                if (this.ValidaFecha(value, DateTime.Now))
                {
                    this.fechaDeNacimiento = value;
                }
            }
        }


        public ETipo TipoPersona { get { return this.tipo; } }
        public int TipoNumero { get { return (int)this.tipo; } }

        // INDEXADOR
        public string this[string index]
        {
            get
            {
                if (index == "nombre") { return this.nombre; }
                if (index == "apellido") { return this.apellido; }
                return "Propiedad inválida. Indice inválido";
            }
            //set { this[index] = value; }
        }

        public string this[int index]
        {
            get
            {
                if (index > -1 && this.notas.Count > 0)
                {
                    return this.notas[index].ToString();
                }
                else return "Error, indice inválido";
            }
        }
    }
}
