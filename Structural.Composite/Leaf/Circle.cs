using Structural.Composite.Component;

namespace Structural.Composite.Leaf
{
    /// <summary>
    /// Represents a circle graphic.
    /// </summary>
    public class Circle : Graphic
    {
        /// <inheritdoc/>
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
