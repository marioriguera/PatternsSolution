namespace Structural.Adapter
{
    /// <summary>
    /// Represents an adapter that converts the interface of a class into another interface expected by the client.
    /// The Adapter makes the Adapter interface compatible with the ITarget interface.
    /// </summary>
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        /// <summary>
        /// Initializes a new instance of the <see cref="Adapter"/> class.
        /// </summary>
        /// <param name="adaptee">The adaptee instance to be adapted.</param>
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        /// <summary>
        /// Gets the request in the format expected by the client.
        /// </summary>
        /// <returns>A string representing the adapted request.</returns>
        public string GetRequest()
        {
            return $"This is the id: {_adaptee.GetSpecificId()} .";
        }
    }
}
