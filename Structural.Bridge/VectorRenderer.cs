namespace Structural.Bridge
{
    /// <summary>
    /// Represents a vector renderer that renders shapes with lines.
    /// </summary>
    public class VectorRenderer : IRenderer
    {
        /// <inheritdoc/>
        public string RenderCircle(float radius)
        {
            return $"Drawing a circle of radius {radius} with lines";
        }
    }
}
