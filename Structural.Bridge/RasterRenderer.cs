namespace Structural.Bridge
{
    /// <summary>
    /// Represents a raster renderer that renders shapes with pixels.
    /// </summary>
    public class RasterRenderer : IRenderer
    {
        /// <inheritdoc/>
        public string RenderCircle(float radius)
        {
            return $"Drawing a circle of radius {radius} with pixels";
        }
    }
}
