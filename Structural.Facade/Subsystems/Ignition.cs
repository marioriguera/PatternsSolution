namespace Structural.Facade.Subsystems
{
    /// <summary>
    /// Represents an ignition system that can be ignited.
    /// </summary>
    public class Ignition : IIgnition
    {
        /// <inheritdoc/>
        public void Ignite()
        {
            Console.WriteLine("Ignition ignited");
        }
    }
}
