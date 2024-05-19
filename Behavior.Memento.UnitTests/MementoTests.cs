namespace Behavior.Memento.UnitTests
{
    /// <summary>
    /// Contains unit tests for the Memento pattern implementation.
    /// </summary>
    public class MementoTests
    {
        /// <summary>
        /// Tests that the originator saves and restores state correctly.
        /// </summary>
        [Fact]
        public void Originator_ShouldSaveAndRestoreStateCorrectly()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            Originator originator = new();
            Caretaker caretaker = new();

            // Act
            originator.State = "State 1";
            caretaker.SaveMemento(originator.CreateMemento());

            originator.State = "State 2";
            originator.RestoreMemento(caretaker.RetrieveMemento());

            // Assert
            Assert.Equal("State 1", originator.State);
            string expectedOutput = "Originator: Setting state to State 1\r\n" +
                                    "Originator: Creating memento\r\n" +
                                    "Originator: Setting state to State 2\r\n" +
                                    "Originator: Restoring state to State 1\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}