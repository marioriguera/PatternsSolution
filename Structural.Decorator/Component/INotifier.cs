namespace Structural.Decorator.Component
{
    /// <summary>
    /// Defines a notifier that sends messages.
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        void Send(string message);
    }
}
