namespace Behavior.ChainOfResponsability.Handlers
{
    /// <summary>
    /// A concrete handler that processes requests within the range of 20 to 29.
    /// </summary>
    public class ConcreteHandler3 : Handler
    {
        /// <inheritdoc/>
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
                return;
            }

            NextHandler?.HandleRequest(request);
        }
    }
}
