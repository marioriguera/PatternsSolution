namespace Structural.Facade.Subsystems
{
    /// <summary>
    /// Represents an engine that can be started and stopped.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Starts the engine.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the engine.
        /// </summary>
        void Stop();
    }
}
