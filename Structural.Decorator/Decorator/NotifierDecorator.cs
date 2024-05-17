using Structural.Decorator.Component;

namespace Structural.Decorator.Decorator
{
    /// <summary>
    /// Represents a base class for notifier decorators.
    /// </summary>
    public abstract class NotifierDecorator : INotifier
    {
        /// <summary>
        /// Wrappe field.
        /// </summary>
        private readonly INotifier _wrappee;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifierDecorator"/> class with the specified notifier to decorate.
        /// </summary>
        /// <param name="wrappee">The notifier to decorate.</param>
        protected NotifierDecorator(INotifier wrappee)
        {
            _wrappee = wrappee;
        }

        /// <inheritdoc/>
        public virtual void Send(string message)
        {
            _wrappee.Send(message);
        }
    }
}
