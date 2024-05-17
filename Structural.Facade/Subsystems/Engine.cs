namespace Structural.Facade.Subsystems
{
    /// <summary>
    /// Represents an engine that can be started and stopped.
    /// </summary>
    public class Engine : IEngine
    {
        /// <inheritdoc/>
        public void Start()
        {
            Console.WriteLine("Engine started");
        }

        /// <inheritdoc/>
        public void Stop()
        {
            Console.WriteLine("Engine stopped");
        }
    }
}
