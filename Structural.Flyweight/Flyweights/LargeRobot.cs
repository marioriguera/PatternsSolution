namespace Structural.Flyweight.Flyweights
{
    /// <summary>
    /// Represents a large robot.
    /// </summary>
    public class LargeRobot : IRobot
    {
        /// <inheritdoc/>
        public void Print()
        {
            Console.WriteLine("This is a large robot");
        }
    }
}
