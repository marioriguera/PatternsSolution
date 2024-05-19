using Behavior.Command.Receivers;

namespace Behavior.Command.Commands
{
    /// <summary>
    /// Represents a command to turn off a light.
    /// </summary>
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        /// <summary>
        /// Initializes a new instance of the <see cref="LightOffCommand"/> class with the specified light.
        /// </summary>
        /// <param name="light">The light to be turned off.</param>
        public LightOffCommand(Light light)
        {
            _light = light;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
