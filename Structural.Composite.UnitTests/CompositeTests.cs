using Structural.Composite.Composite;
using Structural.Composite.Leaf;

namespace Structural.Composite.UnitTests
{
    /// <summary>
    /// Represents tests for the composite pattern implementation.
    /// </summary>
    public class CompositeTests
    {
        /// <summary>
        /// Verifies that drawing a composite with a circle and a square draws correctly.
        /// </summary>
        [Fact]
        public void Draw_CompositeWithCircleAndSquare_DrawsCorrectly()
        {
            // Arrange
            var circle = new Circle();
            var square = new Square();
            var composite = new CompositeGraphic();
            composite.Add(circle);
            composite.Add(square);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                composite.Draw();

                // Assert
                var result = sw.ToString().Trim();
                Assert.Equal("Circle\r\nSquare", result);
            }
        }

        /// <summary>
        /// Verifies that drawing a composite with nested composites draws correctly.
        /// </summary>
        [Fact]
        public void Draw_CompositeWithNestedComposites_DrawsCorrectly()
        {
            // Arrange
            var circle = new Circle();
            var square = new Square();
            var composite1 = new CompositeGraphic();
            composite1.Add(circle);
            composite1.Add(square);

            var composite2 = new CompositeGraphic();
            composite2.Add(composite1);
            composite2.Add(new Circle());

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                composite2.Draw();

                // Assert
                var result = sw.ToString().Trim();
                Assert.Equal("Circle\r\nSquare\r\nCircle", result);
            }
        }
    }
}