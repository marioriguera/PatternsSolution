namespace Structural.Facade.Subsystems
{
    /// <summary>
    /// Represents a fuel injector that can be turned on and off.
    /// </summary>
    public class FuelInjector : IFuelInjector
    {
        /// <inheritdoc/>
        public void On()
        {
            Console.WriteLine("Fuel injector on");
        }

        /// <inheritdoc/>
        public void Off()
        {
            Console.WriteLine("Fuel injector off");
        }
    }
}
