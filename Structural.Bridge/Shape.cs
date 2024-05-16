namespace Structural.Bridge
{
    /// <summary>
    /// Represents an abstract shape class that defines the common behavior for shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class with the specified renderer.
        /// </summary>
        /// <param name="renderer">The renderer to use for drawing the shape.</param>
        protected Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        /// <summary>
        /// Gets the renderer used for drawing the shape.
        /// </summary>
        protected IRenderer Renderer { get; }

        /// <summary>
        /// Draws the shape using the specified renderer.
        /// </summary>
        /// <returns>A string representation of the shape.</returns>
        public abstract string Draw();
    }
}
