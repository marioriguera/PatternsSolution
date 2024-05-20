namespace Behavior.State.UnitTests
{
    /// <summary>
    /// Contains unit tests for verifying the behavior of the State design pattern implementation.
    /// </summary>
    public class StateTests
    {
        /// <summary>
        /// Tests that the context changes its state from ConcreteStateA to ConcreteStateB
        /// when a request is made.
        /// </summary>
        [Fact]
        public void Context_ShouldChangeState_FromAtoB()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            Context context = new(new ConcreteStateA());

            // Act
            context.Request();

            // Assert
            string expectedOutput = "State changed to ConcreteStateA\r\n" +
                                    "Handling request in ConcreteStateA.\r\n" +
                                    "State changed to ConcreteStateB\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }

        /// <summary>
        /// Tests that the context changes its state from ConcreteStateB to ConcreteStateA
        /// when a request is made.
        /// </summary>
        [Fact]
        public void Context_ShouldChangeState_FromBtoA()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            Context context = new(new ConcreteStateB());

            // Act
            context.Request();

            // Assert
            string expectedOutput = "State changed to ConcreteStateB\r\n" +
                                    "Handling request in ConcreteStateB.\r\n" +
                                    "State changed to ConcreteStateA\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}