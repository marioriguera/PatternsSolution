namespace Behavior.Observer.UnitTests
{
    /// <summary>
    /// Contains tests for the observer pattern.
    /// </summary>
    public class ObserverTests
    {
        /// <summary>
        /// Tests that observers are notified when the subject's state changes.
        /// </summary>
        [Fact]
        public void Observers_ShouldBeNotified_WhenSubjectStateChanges()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteSubject subject = new();
            ConcreteObserver observer1 = new("Observer 1");
            ConcreteObserver observer2 = new("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            // Act
            subject.State = "State A";

            // Assert
            string expectedOutput = "Observer Observer 1 updated with state: State A\r\n" +
                                    "Observer Observer 2 updated with state: State A\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }

        /// <summary>
        /// Tests that an observer is not notified after being detached from the subject.
        /// </summary>
        [Fact]
        public void Observer_ShouldNotBeNotified_AfterDetachment()
        {
            // Arrange
            StringWriter output = new();
            Console.SetOut(output);

            ConcreteSubject subject = new();
            ConcreteObserver observer1 = new("Observer 1");
            ConcreteObserver observer2 = new("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            // Act
            subject.Detach(observer1);
            subject.State = "State B";

            // Assert
            string expectedOutput = "Observer Observer 2 updated with state: State B\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}