namespace Structural.Adapter
{
    /// <summary>
    /// Represents the target interface expected by the client.
    /// Destination interface that the client expects.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the request.
        /// </summary>
        /// <returns>A string representing the request.</returns>
        string GetRequest();
    }
}
