namespace Behavior.State
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
            Console.WriteLine("State pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Siguiente estado. Si es primera iteración comienza por el estado A");
            Console.WriteLine("2. Siguiente estado. Si es primera iteración comienza por el estado B");
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
                    NextState(new ConcreteStateA());
                    break;
                case "2":
                    NextState(new ConcreteStateB());
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
        /// Transitions to the next state or initializes the context with the provided state if not already initialized.
        /// </summary>
        /// <param name="concreteState">The state to initialize the context with if it is not already initialized.</param>
        private static void NextState(IState concreteState)
        {
            if (_context == null)
            {
                _context = new Context(concreteState);
                return;
            }

            _context.Request();
        }
    }
}
