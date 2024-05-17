using Structural.Decorator.Component;
using Structural.Decorator.ConcreteComponent;
using Structural.Decorator.Decorator;

namespace Structural.Decorator.UnitTests
{
    /// <summary>
    /// Contains unit tests for the decorator pattern implementations.
    /// </summary>
    public class DecoratorTests
    {
        /// <summary>
        /// Verifies that sending a message through multiple decorators sends the correct messages.
        /// </summary>
        [Fact]
        public void Send_WithMultipleDecorators_SendsCorrectMessages()
        {
            // Arrange
            INotifier notifier = new EmailNotifier();
            notifier = new SMSNotifier(notifier);
            notifier = new FacebookNotifier(notifier);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                notifier.Send("Hello, World!");

                // Assert
                var result = sw.ToString().Trim();
                var expected = "Email: Hello, World!\r\nSMS: Hello, World!\r\nFacebook: Hello, World!";
                Assert.Equal(expected, result);
            }
        }
    }
}