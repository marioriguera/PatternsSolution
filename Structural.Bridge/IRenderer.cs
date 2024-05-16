namespace Structural.Bridge
{
    /// <summary>
    /// Represents an interface for rendering shapes.
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Renders a circle with the specified radius using pixels.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>A string representing the rendered circle.</returns>
        public string RenderCircle(float radius);
    }
}
