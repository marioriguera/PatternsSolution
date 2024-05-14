namespace Creational.Singleton
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
            Console.WriteLine("Sinlgeton pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Crear instancia única de Singleton");
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
            string input = Console.ReadLine() ?? "5";

            switch (input)
            {
                case "1":
                    CreateUniqueInstanceOfSingleton();
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
        /// Creates a unique instance of the Singleton class and calls a method to print the class name.
        /// </summary>
        private static void CreateUniqueInstanceOfSingleton()
        {
            // Get the instance of the Singleton.
            Singleton singleton = Singleton.GetInstance();

            // Call a method of the Singleton that prints the class name to the console.
            singleton.PrintClassName();
        }
    }
}
