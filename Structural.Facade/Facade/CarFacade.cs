using Structural.Facade.Subsystems;

namespace Structural.Facade.Facade
{
    /// <summary>
    /// Facilitates simplified interaction with the components of a car by providing high-level methods for starting and stopping.
    /// </summary>
    public class CarFacade : IEngine
    {
        private readonly IEngine _engine;
        private readonly IFuelInjector _fuelInjector;
        private readonly IIgnition _ignition;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        /// <param name="engine">Optional: The engine component of the car. If not provided, a default engine will be used.</param>
        /// <param name="fuelInjector">Optional: The fuel injector component of the car. If not provided, a default fuel injector will be used.</param>
        /// <param name="ignition">Optional: The ignition component of the car. If not provided, a default ignition will be used.</param>
        public CarFacade(IEngine? engine, IFuelInjector? fuelInjector, IIgnition? ignition)
        {
            _engine = engine ?? new Engine();
            _fuelInjector = fuelInjector ?? new FuelInjector();
            _ignition = ignition ?? new Ignition();
        }

        /// <summary>
        /// Starts the car by turning on the fuel injector, igniting the ignition, and starting the engine.
        /// </summary>
        public void Start()
        {
            _fuelInjector.On();
            _ignition.Ignite();
            _engine.Start();
        }

        /// <summary>
        /// Stops the car by stopping the engine and turning off the fuel injector.
        /// </summary>
        public void Stop()
        {
            _engine.Stop();
            _fuelInjector.Off();
        }
    }
}
