namespace Behavior.Command.Receivers
{
    /// <summary>
    /// Represents a light object that can be turned on and off.
    /// </summary>
    public class Light
    {
        /// <summary>
        /// Turns on the light.
        /// </summary>
        public virtual void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        /// <summary>
        /// Turns off the light.
        /// </summary>
        public virtual void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }
}
