using Structural.Flyweight.Flyweights;

namespace Structural.Flyweight
{
    /// <summary>
    /// Factory for creating and managing instances of robots.
    /// </summary>
    public class RobotFactory
    {
        private readonly Dictionary<string, IRobot> _robots = [];

        /// <summary>
        /// Gets the total number of robots created.
        /// </summary>
        public int TotalRobotsCreated => _robots.Count;

        /// <summary>
        /// Gets a robot of the specified type from the factory. Returns an existing instance if available, otherwise creates a new one.
        /// </summary>
        /// <param name="robotType">The type of robot to get.</param>
        /// <returns>An instance of the specified type of robot.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified robot type is unknown.</exception>
        public IRobot GetRobot(string robotType)
        {
            if (!_robots.TryGetValue(robotType, out IRobot? value))
            {
                value = robotType switch
                {
                    "small" => new SmallRobot(),
                    "large" => new LargeRobot(),
                    _ => throw new ArgumentException($"Unknown robot type: {robotType}"),
                };
                _robots[robotType] = value;
            }

            return value;
        }
    }
}
