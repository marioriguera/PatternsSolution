namespace Behavior.ChainOfResponsability.Handlers
{
    /// <summary>
    /// A concrete handler that processes requests within the range of 0 to 9.
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        /// <inheritdoc/>
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
                return;
            }

            NextHandler?.HandleRequest(request);
        }
    }
}
