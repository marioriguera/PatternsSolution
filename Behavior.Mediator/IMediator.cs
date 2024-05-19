namespace Behavior.Mediator
{
    /// <summary>
    /// Defines an interface for Mediator.
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// Sends a message from a sender to other colleagues.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The colleague sending the message.</param>
        void SendMessage(string message, Colleague sender);
    }
}
