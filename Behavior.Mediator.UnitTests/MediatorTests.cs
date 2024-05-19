namespace Behavior.Mediator.UnitTests
{
    /// <summary>
    /// Contains unit tests for the mediator pattern implementation.
    /// </summary>
    public class MediatorTests
    {
        /// <summary>
        /// Tests that the mediator routes a message from ColleagueA to ColleagueB.
        /// </summary>
        [Fact]
        public void Mediator_ShouldRouteMessageFromColleagueAToColleagueB()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteMediator mediator = new();
            ColleagueA colleagueA = new(mediator);
            ColleagueB colleagueB = new(mediator);
            mediator.ColleagueA = colleagueA;
            mediator.ColleagueB = colleagueB;

            // Act
            colleagueA.SendMessage("Hello from Colleague A!");

            // Assert
            string expectedOutput = "Colleague B received message: Hello from Colleague A!" + Environment.NewLine;
            Assert.Equal(expectedOutput, output.ToString());
        }

        /// <summary>
        /// Tests that the mediator routes a message from ColleagueB to ColleagueA.
        /// </summary>
        [Fact]
        public void Mediator_ShouldRouteMessageFromColleagueBToColleagueA()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteMediator mediator = new();
            ColleagueA colleagueA = new(mediator);
            ColleagueB colleagueB = new(mediator);
            mediator.ColleagueA = colleagueA;
            mediator.ColleagueB = colleagueB;

            // Act
            colleagueB.SendMessage("Hello from Colleague B!");

            // Assert
            string expectedOutput = "Colleague A received message: Hello from Colleague B!" + Environment.NewLine;
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}