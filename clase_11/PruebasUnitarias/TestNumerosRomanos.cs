

using System.Text;

namespace PruebasUnitarias
{
    [TestClass] // Se debe declarar la clase entera como test para pruebas unitarias
    public class TestNumerosRomanos
    {
        [TestMethod]
        // el nombre del método se hizo como: given_when_then
        public void AlRecibirUnNumeroUno_EnDecimal_DeberiaObtenerUnNumeroRomano()
        {
            // * Arrange
            // given
            int numero = 1;
            string esperado = "I";

            // * Act
            // when
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            // * Assert
            // then
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod] // Si no se indica como metodo de prueba con el decorador, no aparece el metodo al ejecutar el test
        public void AlRecibirUnNumeroDos_EnDecimal_DeberiaObtenerUnNumeroRomano()
        {
            // * Arrange
            // given
            int numero = 2;
            string esperado = "II";

            // * Act
            // when
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            // * Assert
            // then
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        [DataRow(1)] // Decorador para asignarle valores al metodo
        [DataRow(2)]
        public void AlRecibirUnNumeroEntero_EnDecimal_DeberiaObtenerSuEquivalenteEnRomano(int value)
        {
            // * Arrange
            // given
            StringBuilder sb = new StringBuilder();
            sb.Append('I', value);
            string esperado = sb.ToString();

            // * Act
            // when
            string resultado = Conversor.ConvertirANumeroRomano(value);

            // * Assert
            // then
            Assert.AreEqual(resultado, esperado);
        }


        [TestMethod]
        [DataRow(0)]
        [ExpectedException(typeof(NumeroInvalidoException))]
        public void AlRecibirInvalido_DeberiaObtenerUnError(int nro)
        {
            // * Arrange
            // given

            // * Act
            // when
            string resultado = Conversor.ConvertirANumeroRomano(nro);

            // * Assert
            // then
            //Assert.AreEqual(resultado, "I");
        }
    }
}