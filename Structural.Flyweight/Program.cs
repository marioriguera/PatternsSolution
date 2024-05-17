using Structural.Flyweight.Flyweights;

namespace Structural.Flyweight
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function.
        /// </summary>
        /// <param name="args">String array of arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Length == 0) Console.WriteLine("Console arguments array its empty.");

            bool exitRequested = false;
            while (!exitRequested)
            {
                GetOption();

                exitRequested = GetRequested(exitRequested);

                GetExitMessages();
            }

            Console.WriteLine("¡Hasta luego! Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Get option menu console.
        /// </summary>
        private static void GetOption()
        {
            Console.WriteLine("Flyweight pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Crear y compartir robots.");
            Console.WriteLine("2. Salir");
        }

        /// <summary>
        /// Prompts the user to select an option and returns whether an exit has been requested.
        /// </summary>
        /// <param name="exitRequested">A boolean indicating whether an exit has been requested.</param>
        /// <returns>True if an exit has been requested; otherwise, false.</returns>
        private static bool GetRequested(bool exitRequested)
        {
            Console.Write("Seleccione una opción: ");
            string input = Console.ReadLine() ?? "2";

            switch (input)
            {
                case "1":
                    CreateAndShareRobots();
                    break;
                case "2":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            return exitRequested;
        }

        /// <summary>
        /// Get exit messages to close console.
        /// </summary>
        private static void GetExitMessages()
        {
            Console.WriteLine(); // Line break to separate menu iterations.
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Clear the console to show the menu again.
        }

        /// <summary>
        /// Creates and shares instances of small and large robots using a robot factory.
        /// </summary>
        private static void CreateAndShareRobots()
        {
            RobotFactory factory = new();

            // Get robots and share them
            IRobot smallRobot1 = factory.GetRobot("small");
            smallRobot1.Print();

            IRobot smallRobot2 = factory.GetRobot("small");
            smallRobot2.Print();

            IRobot largeRobot1 = factory.GetRobot("large");
            largeRobot1.Print();

            IRobot largeRobot2 = factory.GetRobot("large");
            largeRobot2.Print();

            Console.WriteLine($"Total robots created: {factory.TotalRobotsCreated}");
        }
    }
}
