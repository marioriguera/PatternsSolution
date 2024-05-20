namespace Behavior.Strategy
{
    /// <summary>
    /// Defines the context that uses a strategy.
    /// </summary>
    public class Context
    {
        private IStrategy _strategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class with the specified strategy.
        /// </summary>
        /// <param name="strategy">The strategy to use.</param>
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Sets the strategy used by the context.
        /// </summary>
        /// <param name="strategy">The new strategy to use.</param>
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Executes the current strategy.
        /// </summary>
        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }
}
