using Behavior.Command.Receivers;

namespace Behavior.Command.Commands
{
    /// <summary>
    /// Represents a command to turn on a light.
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        /// <summary>
        /// Initializes a new instance of the <see cref="LightOnCommand"/> class with the specified light.
        /// </summary>
        /// <param name="light">The light to be turned on.</param>
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
