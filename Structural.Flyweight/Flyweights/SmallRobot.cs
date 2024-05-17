namespace Structural.Flyweight.Flyweights
{
    /// <summary>
    /// Represents a small robot.
    /// </summary>
    public class SmallRobot : IRobot
    {
        /// <inheritdoc/>
        public void Print()
        {
            Console.WriteLine("This is a small robot");
        }
    }
}
