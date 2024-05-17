namespace Structural.Flyweight.UnitTests
{
    /// <summary>
    /// Tests for the Flyweight pattern implementation.
    /// </summary>
    public class FlyweightTests
    {
        /// <summary>
        /// Verifies that getting a small robot from the factory returns the same instance.
        /// </summary>
        [Fact]
        public void GetRobot_SmallRobot_ReturnsSameInstance()
        {
            // Arrange
            var factory = new RobotFactory();

            // Act
            var robot1 = factory.GetRobot("small");
            var robot2 = factory.GetRobot("small");

            // Assert
            Assert.Same(robot1, robot2);
        }

        /// <summary>
        /// Verifies that getting a large robot from the factory returns the same instance.
        /// </summary>
        [Fact]
        public void GetRobot_LargeRobot_ReturnsSameInstance()
        {
            // Arrange
            var factory = new RobotFactory();

            // Act
            var robot1 = factory.GetRobot("large");
            var robot2 = factory.GetRobot("large");

            // Assert
            Assert.Same(robot1, robot2);
        }

        /// <summary>
        /// Verifies that the total number of robots created is correct after creating some robots.
        /// </summary>
        [Fact]
        public void TotalRobotsCreated_GetAfterCreatingSomeRobots_ReturnsCorrectCount()
        {
            // Arrange
            var factory = new RobotFactory();

            // Act
            _ = factory.GetRobot("small");
            _ = factory.GetRobot("large");
            _ = factory.GetRobot("small");

            // Assert
            Assert.Equal(2, factory.TotalRobotsCreated);
        }
    }
}