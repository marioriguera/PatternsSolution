namespace Behavior.State
{
    /// <summary>
    /// Defines an interface for encapsulating the behavior associated with a particular state of the Context.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Handles the state-specific behavior and transitions the context to another state if needed.
        /// </summary>
        /// <param name="context">The context whose behavior is determined by the current state.</param>
        void Handle(Context context);
    }
}
