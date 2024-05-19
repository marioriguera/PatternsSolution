using Behavior.ChainOfResponsability.Handlers;
using Moq;

namespace Behavior.ChainOfResponsability.UnitTests
{
    /// <summary>
    /// Contains unit tests for the handler classes.
    /// </summary>
    public class HandlerTests
    {
        /// <summary>
        /// Tests that ConcreteHandler1 handles a request within its range.
        /// </summary>
        [Fact]
        public void ConcreteHandler1_ShouldHandleRequest_WhenRequestIsInRange()
        {
            // Arrange
            var handler1 = new ConcreteHandler1();
            var handler2 = new Mock<Handler>().Object;
            handler1.SetNext(handler2);

            // Act
            var writer = new System.IO.StringWriter();
            Console.SetOut(writer);
            handler1.HandleRequest(5);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("ConcreteHandler1 handled request 5", output);
        }

        /// <summary>
        /// Tests that ConcreteHandler2 handles a request within its range.
        /// </summary>
        [Fact]
        public void ConcreteHandler2_ShouldHandleRequest_WhenRequestIsInRange()
        {
            // Arrange
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            handler1.SetNext(handler2);
            var handler3 = new Mock<Handler>().Object;
            handler2.SetNext(handler3);

            // Act
            var writer = new System.IO.StringWriter();
            Console.SetOut(writer);
            handler1.HandleRequest(14);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("ConcreteHandler2 handled request 14", output);
        }

        /// <summary>
        /// Tests that ConcreteHandler3 handles a request within its range.
        /// </summary>
        [Fact]
        public void ConcreteHandler3_ShouldHandleRequest_WhenRequestIsInRange()
        {
            // Arrange
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            var handler3 = new ConcreteHandler3();
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            // Act
            var writer = new System.IO.StringWriter();
            Console.SetOut(writer);
            handler1.HandleRequest(22);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("ConcreteHandler3 handled request 22", output);
        }

        /// <summary>
        /// Tests that a request is passed to the next handler when it is not handled by the current handler.
        /// </summary>
        [Fact]
        public void ShouldPassRequestToNextHandler_WhenRequestIsNotHandled()
        {
            // Arrange
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            handler1.SetNext(handler2);
            var handler3Mock = new Mock<Handler>();
            handler2.SetNext(handler3Mock.Object);

            // Act
            handler1.HandleRequest(25);

            // Assert
            handler3Mock.Verify(h => h.HandleRequest(25), Times.Once);
        }
    }
}