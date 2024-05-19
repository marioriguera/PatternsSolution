using Behavior.Command.Commands;

namespace Behavior.Command.Invokers
{
    /// <summary>
    /// Represents a remote control that can be used to execute commands.
    /// </summary>
    public class RemoteControl
    {
        private ICommand? _command;

        /// <summary>
        /// Sets the command to be executed by the remote control.
        /// </summary>
        /// <param name="command">The command to be set.</param>
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Presses a button on the remote control, executing the currently set command.
        /// </summary>
        public void PressButton()
        {
            _command?.Execute();
        }
    }
}
