namespace Behavior.ChainOfResponsability.Handlers
{
    /// <summary>
    /// A concrete handler that processes requests within the range of 10 to 19.
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        /// <inheritdoc/>
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
                return;
            }

            NextHandler?.HandleRequest(request);
        }
    }
}
