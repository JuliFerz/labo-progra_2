using Entidades.Interfaces;
using Entidades.Models;

namespace UnitTestingAhorcado
{
    [TestClass]
    public class UnitTestingToAhorcado
    {
        [TestMethod]
        [ExpectedException(typeof(FileManagerException))]
        public void ForzarEjecucion_DeFileManagerException_RetornaException()
        {
            // Arrange
            Ahorcado<Pais> ahorcado = new Ahorcado<Pais>();

            // Act && Assert
            FileManager.Guardar(ahorcado, "/test.test");
        }

        [TestMethod]
        public void AlInstanciar_NuevoJuego_CantidadDeAcierosEsCero()
        {
            // Arrange
            Ahorcado<Pais> ahorcado;

            // Act
            ahorcado = new Ahorcado<Pais>();

            // Assert
            Assert.AreEqual(ahorcado.CantidadDeAciertos, 0);
        }
    }
}