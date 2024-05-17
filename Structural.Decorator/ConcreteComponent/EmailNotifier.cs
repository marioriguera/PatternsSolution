using Structural.Decorator.Component;

namespace Structural.Decorator.ConcreteComponent
{
    /// <summary>
    /// Represents a notifier that sends messages via email.
    /// </summary>
    public class EmailNotifier : INotifier
    {
        /// <inheritdoc/>
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
