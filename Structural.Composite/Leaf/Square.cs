using Structural.Composite.Component;

namespace Structural.Composite.Leaf
{
    /// <summary>
    /// Represents a square graphic.
    /// </summary>
    public class Square : Graphic
    {
        /// <inheritdoc/>
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
