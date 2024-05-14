namespace Creational.Prototype.UnitTests
{
    /// <summary>
    /// Represents tests for the prototype pattern implementation.
    /// </summary>
    public class PrototypeTests
    {
        /// <summary>
        /// Verifies that cloning returns a new instance of the prototype with the same values.
        /// </summary>
        [Fact]
        public void Clone_ReturnsNewInstanceOfPrototypeWithSameValues()
        {
            // Arrange
            var prototype = new ConcretePrototype { Id = 1 };

            // Act
            var clonedPrototype = prototype.Clone();

            // Assert
            Assert.NotSame(prototype, clonedPrototype); // Verify that they are not the same instance
            Assert.Equal(prototype.Id, clonedPrototype.Id); // Verify that they have the same values
        }
    }
}