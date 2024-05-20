namespace Behavior.Visitor.UnitTests
{
    /// <summary>
    /// Tests for the Visitor pattern.
    /// </summary>
    public class VisitorTests
    {
        /// <summary>
        /// Tests if the concrete visitor correctly visits ConcreteElementA and performs OperationA.
        /// </summary>
        [Fact]
        public void ConcreteVisitor_ShouldVisitConcreteElementA_AndPerformOperationA()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteVisitor visitor = new();
            ConcreteElementA elementA = new();

            // Act
            elementA.Accept(visitor);

            // Assert
            string expectedOutput = "ConcreteVisitor: Performing specific operation of ConcreteElementA: Specific operation of ConcreteElementA\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }

        /// <summary>
        /// Tests if the concrete visitor correctly visits ConcreteElementB and performs OperationB.
        /// </summary>
        [Fact]
        public void ConcreteVisitor_ShouldVisitConcreteElementB_AndPerformOperationB()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteVisitor visitor = new();
            ConcreteElementB elementB = new();

            // Act
            elementB.Accept(visitor);

            // Assert
            string expectedOutput = "ConcreteVisitor: Performing specific operation of ConcreteElementB: Specific operation of ConcreteElementB\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}