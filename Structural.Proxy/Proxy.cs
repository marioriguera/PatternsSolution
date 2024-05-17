namespace Structural.Proxy
{
    /// <summary>
    /// The Proxy class, which controls access to a RealSubject instance.
    /// Implements the ISubject interface.
    /// </summary>
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;
        private int _requestCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy"/> class.
        /// </summary>
        public Proxy()
        {
            _realSubject = new RealSubject();
            _requestCount = 0;
        }

        /// <inheritdoc/>
        public void Request()
        {
            Console.WriteLine("Proxy: Forwarding request to RealSubject.");
            _realSubject.Request();
            _requestCount++;
            Console.WriteLine($"Proxy: Request count: {_requestCount}");
        }
    }
}
