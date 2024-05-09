namespace Creational.FactoryMethod.UnitTests
{
    /// <summary>
    /// Represents tests for the Creator class and its concrete creators.
    /// </summary>
    public class CreatorTests
    {
        /// <summary>
        /// Tests the FactoryMethod of ConcreteCreatorA to ensure it returns the correct product.
        /// </summary>
        [Fact]
        public void CreatorA_FactoryMethod_ReturnsCorrectProduct()
        {
            // Arrange
            Creator creator = new ConcreteCreatorA();

            // Act
            IProduct product = creator.FactoryMethod();

            // Assert
            Assert.IsType<ConcreteProductA>(product);
        }

        /// <summary>
        /// Tests the FactoryMethod of ConcreteCreatorB to ensure it returns the correct product.
        /// </summary>
        [Fact]
        public void CreatorB_FactoryMethod_ReturnsCorrectProduct()
        {
            // Arrange
            Creator creator = new ConcreteCreatorB();

            // Act
            IProduct product = creator.FactoryMethod();

            // Assert
            Assert.IsType<ConcreteProductB>(product);
        }
    }
}