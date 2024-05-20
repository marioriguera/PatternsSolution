namespace Behavior.Strategy
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static Context? _context;

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
            Console.WriteLine("Strategy pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Ejecutar estrategia A");
            Console.WriteLine("2. Ejecutar estrategia B");
            Console.WriteLine("3. Salir");
        }

        /// <summary>
        /// Prompts the user to select an option and returns whether an exit has been requested.
        /// </summary>
        /// <param name="exitRequested">A boolean indicating whether an exit has been requested.</param>
        /// <returns>True if an exit has been requested; otherwise, false.</returns>
        private static bool GetRequested(bool exitRequested)
        {
            Console.Write("Seleccione una opción: ");
            string input = Console.ReadLine() ?? "3";

            switch (input)
            {
                case "1":
                    ExecuteStrategy(new ConcreteStrategyA());
                    break;
                case "2":
                    ExecuteStrategy(new ConcreteStrategyB());
                    break;
                case "3":
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
        /// Executes a strategy within the context.
        /// </summary>
        /// <param name="strategy">The strategy to execute.</param>
        private static void ExecuteStrategy(IStrategy strategy)
        {
            SetContextStrategy(strategy);
            _context?.ExecuteStrategy();
        }

        /// <summary>
        /// Sets the strategy for the context or creates a new context with the specified strategy.
        /// </summary>
        /// <param name="strategy">The strategy to set.</param>
        private static void SetContextStrategy(IStrategy strategy)
        {
            if (_context != null)
            {
                _context.SetStrategy(strategy);
            }
            else
            {
                _context = new Context(strategy);
            }
        }
    }
}
