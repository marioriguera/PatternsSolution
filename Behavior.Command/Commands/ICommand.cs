namespace Behavior.Command.Commands
{
    /// <summary>
    /// Represents a command interface.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Execute();
    }
}
