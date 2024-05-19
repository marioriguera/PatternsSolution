namespace Behavior.ChainOfResponsability.Handlers
{
    /// <summary>
    /// Represents an abstract handler in the chain of responsibility pattern.
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// Gets or sets the next handler in the chain.
        /// </summary>
        protected Handler? NextHandler { get; set; }

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="handler">The handler to be set as the next handler.</param>
        public void SetNext(Handler handler)
        {
            NextHandler = handler;
        }

        /// <summary>
        /// Handles the request or passes it to the next handler in the chain.
        /// </summary>
        /// <param name="request">The request to be handled.</param>
        public abstract void HandleRequest(int request);
    }
}
