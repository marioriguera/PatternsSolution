namespace Structural.Bridge.UnitTests
{
    /// <summary>
    /// Represents tests for the bridge pattern implementation.
    /// </summary>
    public class BridgeTests
    {
        /// <summary>
        /// Verifies that drawing a circle with a vector renderer returns the correct string.
        /// </summary>
        [Fact]
        public void Draw_CircleWithVectorRenderer_ReturnsCorrectString()
        {
            // Arrange
            IRenderer vectorRenderer = new VectorRenderer();
            Shape circle = new Circle(vectorRenderer, 5);

            // Act
            string result = circle.Draw();

            // Assert
            Assert.Equal("Drawing a circle of radius 5 with lines", result);
        }

        /// <summary>
        /// Verifies that drawing a circle with a raster renderer returns the correct string.
        /// </summary>
        [Fact]
        public void Draw_CircleWithRasterRenderer_ReturnsCorrectString()
        {
            // Arrange
            IRenderer rasterRenderer = new RasterRenderer();
            Shape circle = new Circle(rasterRenderer, 5);

            // Act
            string result = circle.Draw();

            // Assert
            Assert.Equal("Drawing a circle of radius 5 with pixels", result);
        }
    }
}