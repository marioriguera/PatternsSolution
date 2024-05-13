namespace Creational.AbstractFactory.UnitTests
{
    /// <summary>
    /// Represents tests for the Abstract Factory pattern implementation.
    /// </summary>
    public class AbstractFactoryTests
    {
        /// <summary>
        /// Tests the creation of Product A and verifies correct instances are returned.
        /// </summary>
        [Fact]
        public void CreateProductA_ReturnsCorrectInstances()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory();

            // Act
            IProductA productA1 = factory.CreateProductA("A1");
            IProductA productA2 = factory.CreateProductA("A2");

            // Assert
            Assert.IsType<ConcreteProductA1>(productA1);
            Assert.IsType<ConcreteProductA2>(productA2);
        }

        /// <summary>
        /// Tests the creation of Product B and verifies correct instances are returned.
        /// </summary>
        [Fact]
        public void CreateProductB_ReturnsCorrectInstances()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory();

            // Act
            IProductB productB1 = factory.CreateProductB("B1");
            IProductB productB2 = factory.CreateProductB("B2");

            // Assert
            Assert.IsType<ConcreteProductB1>(productB1);
            Assert.IsType<ConcreteProductB2>(productB2);
        }

        /// <summary>
        /// Tests the creation of Product A with an invalid type and verifies that an exception is thrown.
        /// </summary>
        [Fact]
        public void CreateProductA_InvalidType_ThrowsException()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateProductA("InvalidType"));
        }

        /// <summary>
        /// Tests the creation of Product B with an invalid type and verifies that an exception is thrown.
        /// </summary>
        [Fact]
        public void CreateProductB_InvalidType_ThrowsException()
        {
            // Arrange
            IAbstractFactory factory = new ConcreteFactory();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateProductB("InvalidType"));
        }
    }
}