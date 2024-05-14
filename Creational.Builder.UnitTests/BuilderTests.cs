namespace Creational.Builder.UnitTests
{
    /// <summary>
    /// Represents tests for the builder pattern implementation.
    /// </summary>
    public class BuilderTests
    {
        /// <summary>
        /// Verifies that the product has correct parts after construction.
        /// </summary>
        [Fact]
        public void Product_ShouldHaveCorrectPartsAfterConstruction()
        {
            // Arrange
            var builder = new ConcreteBuilder();
            var director = new Director(builder);

            // Act
            director.Construct();
            var product = builder.GetResult();

            // Assert
            Assert.Equal("Part 1 built", product.Part1);
            Assert.Equal("Part 2 built", product.Part2);
            Assert.Equal("Part 3 built", product.Part3);
        }
    }
}