namespace Structural.Proxy
{
    /// <summary>
    /// The RealSubject class, which handles the actual request.
    /// Implements the ISubject interface.
    /// </summary>
    public class RealSubject : ISubject
    {
        /// <inheritdoc/>
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }
}
