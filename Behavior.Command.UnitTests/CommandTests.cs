using Behavior.Command.Commands;
using Behavior.Command.Invokers;
using Behavior.Command.Receivers;
using Moq;

namespace Behavior.Command.UnitTests
{
    /// <summary>
    /// Contains unit tests for the command pattern implementation.
    /// </summary>
    public class CommandTests
    {
        /// <summary>
        /// Tests that the LightOnCommand turns on the light.
        /// </summary>
        [Fact]
        public void LightOnCommand_ShouldTurnOnLight()
        {
            // Arrange
            var lightMock = new Mock<Light>();
            var lightOnCommand = new LightOnCommand(lightMock.Object);
            var remote = new RemoteControl();

            // Act
            remote.SetCommand(lightOnCommand);
            remote.PressButton();

            // Assert
            lightMock.Verify(l => l.TurnOn(), Times.Once);
        }

        /// <summary>
        /// Tests that the LightOffCommand turns off the light.
        /// </summary>
        [Fact]
        public void LightOffCommand_ShouldTurnOffLight()
        {
            // Arrange
            var lightMock = new Mock<Light>();
            var lightOffCommand = new LightOffCommand(lightMock.Object);
            var remote = new RemoteControl();

            // Act
            remote.SetCommand(lightOffCommand);
            remote.PressButton();

            // Assert
            lightMock.Verify(l => l.TurnOff(), Times.Once);
        }
    }
}