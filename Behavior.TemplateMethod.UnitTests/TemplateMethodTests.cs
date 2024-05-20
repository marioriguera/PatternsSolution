namespace Behavior.TemplateMethod.UnitTests
{
    /// <summary>
    /// Tests for verifying the behavior of template method pattern.
    /// </summary>
    public class TemplateMethodTests
    {
        /// <summary>
        /// Verifies that ConcreteClass1 executes the template method with the correct order of steps.
        /// </summary>
        [Fact]
        public void ConcreteClass1_ShouldExecuteTemplateMethod_WithCorrectOrderOfSteps()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteClass1 concrete1 = new();

            // Act
            concrete1.TemplateMethod();

            // Assert
            string expectedOutput = "ConcreteClass1: Implementing Step1\r\n" +
                                    "AbstractClass: Default implementation of Step2\r\n" +
                                    "ConcreteClass1: Implementing Step3\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }

        /// <summary>
        /// Verifies that ConcreteClass2 executes the template method with the correct order of steps.
        /// </summary>
        [Fact]
        public void ConcreteClass2_ShouldExecuteTemplateMethod_WithCorrectOrderOfSteps()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteClass2 concrete2 = new();

            // Act
            concrete2.TemplateMethod();

            // Assert
            string expectedOutput = "ConcreteClass2: Implementing Step1\r\n" +
                                    "ConcreteClass2: Implementing Step2\r\n" +
                                    "ConcreteClass2: Implementing Step3\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}