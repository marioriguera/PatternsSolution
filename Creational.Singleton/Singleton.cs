namespace Creational.Singleton
{
    /// <summary>
    /// Represents a singleton class that ensures only one instance is created.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly object _lock = new();
        private static Singleton? _instance;
        private readonly string _name = $"The name is {nameof(Singleton)}.";

        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton"/> class.
        /// Private constructor to prevent external instantiation.
        /// </summary>
        private Singleton()
        {
            // Private constructor to prevent instantiation outside the class.
        }

        /// <summary>
        /// Static method to get the single instance of the class.
        /// </summary>
        /// <returns>The single instance of the class.</returns>
        public static Singleton GetInstance()
        {
            // Check if the instance already exists.
            if (_instance == null)
            {
                // Use locking to ensure thread safety in multi-threaded environments.
                lock (_lock)
                {
                    // Double check inside the lock to prevent creation of multiple instances in multi-threaded environments.
                    _instance ??= new Singleton();
                }
            }

            return _instance;
        }

        /// <summary>
        /// Print in closole the private name of the class.
        /// </summary>
        public void PrintClassName()
        {
            Console.WriteLine(_name);
        }
    }
}
