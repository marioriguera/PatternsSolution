namespace Behavior.TemplateMethod
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
            Console.WriteLine("Template Method pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Utilizar algoritmo 1");
            Console.WriteLine("2. Utilizar algoritmo 2");
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
                    ExecuteConcreteAlgorithm(new ConcreteClass1());
                    break;
                case "2":
                    ExecuteConcreteAlgorithm(new ConcreteClass2());
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
        /// Executes the template method of the provided concrete algorithm.
        /// </summary>
        /// <param name="concreteAlgorithm">The concrete algorithm instance to execute.</param>
        private static void ExecuteConcreteAlgorithm(AbstractClass concreteAlgorithm)
        {
            AbstractClass concrete1 = concreteAlgorithm;
            concrete1.TemplateMethod();
        }
    }
}
