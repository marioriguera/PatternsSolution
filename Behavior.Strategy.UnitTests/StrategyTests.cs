namespace Behavior.Strategy.UnitTests
{
    /// <summary>
    /// Contains unit tests for executing strategies in the context.
    /// </summary>
    public class StrategyTests
    {
        /// <summary>
        /// Tests if the context executes ConcreteStrategyA correctly.
        /// </summary>
        [Fact]
        public void Context_ShouldExecuteConcreteStrategyA()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            Context context = new(new ConcreteStrategyA());

            // Act
            context.ExecuteStrategy();

            // Assert
            Assert.Equal("Executing ConcreteStrategyA.\r\n", output.ToString());
        }

        /// <summary>
        /// Tests if the context executes ConcreteStrategyB correctly.
        /// </summary>
        [Fact]
        public void Context_ShouldExecuteConcreteStrategyB()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            Context context = new(new ConcreteStrategyB());

            // Act
            context.ExecuteStrategy();

            // Assert
            Assert.Equal("Executing ConcreteStrategyB.\r\n", output.ToString());
        }
    }
}