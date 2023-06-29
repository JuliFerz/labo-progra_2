using Entidades.Exceptions;
using Entidades.Modelos;

namespace UnitTestingCocina
{
    [TestClass]
    public class UnitTestingToCocina
    {
        [TestMethod]
        [ExpectedException(typeof(FileManagerException))]
        public void ForzarEjecucion_DeFileManagerException_RetornaException()
        {
            // Arrange
            Cocinero<Hamburguesa> hamburguesero;

            // Act
            hamburguesero = new Cocinero<Hamburguesa>("Ramon");

            // Act && Assert
            FileManager.Guardar("test", "test.test", false);
        }

        [TestMethod]
        public void AlInstanciar_NuevoCocinero_CantidadDePedidosEsCero()
        {
            // Arrange
            Cocinero<Hamburguesa> hamburguesero;

            // Act
            hamburguesero = new Cocinero<Hamburguesa>("Ramon");

            // Assert
            Assert.AreEqual(hamburguesero.CantPedidosFinalizados, 0);
        }
    }
}