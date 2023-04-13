namespace Entidades
{
    public class Calculadora
    {
        public int resultado;

        // Sobrecarga de parametros del constructor
        public Calculadora()
        {
            this.resultado = 0;
        }
        // Tipos de sobrecarga de parámetros
        /*
         */
        public Calculadora(int resultado)
        {
            this.resultado = resultado;
        }





        // Tipos de sobrecarga de métodos
        /*
         *  1- Cambiar la cantidad de parametros
         *  2- Cambiar el tipo de parametros
         *  3- Cambiar el orden de parametros
         */

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        // 1- Sobrecarga del método Sumar (cambiar cant. parametros)
        public int Sumar(int numero1, int numero2, int numero3)
        {
            return this.Sumar(numero1, numero2) + numero3;
        }

        // 2- Sobrecarga del método Sumar (cambiar tipo parametros)
        public float Sumar(float numero1, float numero2)
        {
            // No es valido porque estoy cambiando el retorno
            return numero2 + numero1;
        }

        // 3- Sobrecarga del método Sumar (cambiar orden parametros)
        // NO es tan comun hacer este tipo de sobrecarga, porque si un
        // método tiene muchos parametros, es tedioso ir uno por uno cambiarles 
        // el orden y tipo.
        public float Sumar(float numero1, int numero2)
        {
            // No es valido porque estoy cambiando el retorno
            return numero2 + numero1;
        }
        public float Sumar(int numero1, float numero2)
        {
            // No es valido porque estoy cambiando el retorno
            return numero2 + numero1;
        }

    }
}