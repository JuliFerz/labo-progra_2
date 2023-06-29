namespace _11_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EnvioNumeroUno_AlMetodoContador_ReciboLongitudUno()
        {
            // Arrange
            long i = 0;

            // Act & Assert
            Assert.AreEqual(i.ContarCantidadDeDigitos(), 1);
        }

        [TestMethod]
        public void EnvioNumeroDeDiezDigitos_AlMetodoContador_ReciboLongitudDiez()
        {
            // Arrange
            long i = 1234567890;

            // Act
            int result = i.ContarCantidadDeDigitos();

            // Assert
            Assert.AreEqual(result, 10);
        }
    }
}