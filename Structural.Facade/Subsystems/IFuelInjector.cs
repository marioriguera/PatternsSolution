namespace Structural.Facade.Subsystems
{
    /// <summary>
    /// Represents a fuel injector that can be turned on and off.
    /// </summary>
    public interface IFuelInjector
    {
        /// <summary>
        /// Turns on the fuel injector.
        /// </summary>
        void On();

        /// <summary>
        /// Turns off the fuel injector.
        /// </summary>
        void Off();
    }
}
