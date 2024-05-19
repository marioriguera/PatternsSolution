namespace Behavior.Memento
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static readonly Originator _originator = new();
        private static readonly Caretaker _caretaker = new();

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
            Console.WriteLine("Memento pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Cambiar originador");
            Console.WriteLine("2. Restaurar originador");
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
                    ChangeOriginator();
                    break;
                case "2":
                    RestoreOriginator();
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
        /// Changes the state of the originator and saves the current state as a memento.
        /// </summary>
        private static void ChangeOriginator()
        {
            _originator.State = "State 1";
            _caretaker.SaveMemento(_originator.CreateMemento());
        }

        /// <summary>
        /// Restores the state of the originator to a previously saved state.
        /// </summary>
        private static void RestoreOriginator()
        {
            _originator.State = "State 2";
            _originator.RestoreMemento(_caretaker.RetrieveMemento());
        }
    }
}
