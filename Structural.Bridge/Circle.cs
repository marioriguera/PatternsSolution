namespace Structural.Bridge
{
    /// <summary>
    /// Represents a circle shape.
    /// </summary>
    public class Circle : Shape
    {
        private readonly float _radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified renderer and radius.
        /// </summary>
        /// <param name="renderer">The renderer to use for drawing the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public Circle(IRenderer renderer, float radius)
            : base(renderer)
        {
            _radius = radius;
        }

        /// <inheritdoc/>
        public override string Draw()
        {
            return Renderer.RenderCircle(_radius);
        }
    }
}
