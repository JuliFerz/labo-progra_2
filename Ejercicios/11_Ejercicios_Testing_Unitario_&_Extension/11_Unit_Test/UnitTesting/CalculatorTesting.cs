using Entidades.Models;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestsCalc
    {
        [TestMethod]
        [DataRow("")]
        public void RecibirStringVacio_EnMetodoAdd_Devuelve0(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        [DataRow("3")]
        public void RecibirNumeroEnString_EnMetodoAdd_DevuelveMismoNumeroEnEnterio(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        [DataRow("3,2")]
        public void RecibirDosNumeros_EnMetodoAdd_DevuelveSuma(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        [DataRow("a")]
        [ExpectedException(typeof(FormatException))]
        public void RecibirNumeroInvalido_EnMetodoAdd_DevuelveException(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
        }

        [TestMethod]
        [DataRow("3 2,2")]
        public void RecibirVariosNumeros_EnMetodoAdd_DevuelveSuma(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        [DataRow("6 4 5")]
        public void RecibirNumerosConEspacio_EnMetodoAdd_DevuelveSuma(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        [DataRow("//; 2;3;5")]
        public void RecibirNumerosConOtroPatron_EnMetodoAdd_DevuelveSuma(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        [DataRow("6 -4")]
        [ExpectedException(typeof(CalculatorExceptions))]
        public void RecibirNumeroNegativo_EnMetodoAdd_DevuelveException(string nro)
        {
            // Arrange
            // Act
            int result = Calculator.Add(nro);
            // Assert
            //Assert.AreEqual(result, 2);
        }
    }
}