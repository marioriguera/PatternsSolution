using Structural.Decorator.Component;

namespace Structural.Decorator.Decorator
{
    /// <summary>
    /// Represents a notifier that sends messages via Facebook, decorating an existing notifier.
    /// </summary>
    public class FacebookNotifier : NotifierDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacebookNotifier"/> class with the specified notifier to decorate.
        /// </summary>
        /// <param name="wrappee">The notifier to decorate.</param>
        public FacebookNotifier(INotifier wrappee)
            : base(wrappee)
        {
        }

        /// <inheritdoc/>
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Facebook: {message}");
        }
    }
}
