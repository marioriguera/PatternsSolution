namespace Behavior.Visitor
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static readonly ConcreteVisitor _visitor = new();
        private static readonly ObjectStructure _objectStructure = new();

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
            Console.WriteLine("Visitor pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Visitar elemento A");
            Console.WriteLine("2. Visitar elemento B");
            Console.WriteLine("3. Visitar ambos elementos");
            Console.WriteLine("4. Salir");
        }

        /// <summary>
        /// Prompts the user to select an option and returns whether an exit has been requested.
        /// </summary>
        /// <param name="exitRequested">A boolean indicating whether an exit has been requested.</param>
        /// <returns>True if an exit has been requested; otherwise, false.</returns>
        private static bool GetRequested(bool exitRequested)
        {
            Console.Write("Seleccione una opción: ");
            string input = Console.ReadLine() ?? "4";

            switch (input)
            {
                case "1":
                    VisitElement(new ConcreteElementA());
                    break;
                case "2":
                    VisitElement(new ConcreteElementB());
                    break;
                case "3":
                    VisitAllElements();
                    break;
                case "4":
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
        /// Visits all elements in the object structure.
        /// </summary>
        private static void VisitAllElements()
        {
            VisitElement(new ConcreteElementA());
            VisitElement(new ConcreteElementB());
        }

        /// <summary>
        /// Visits a specific element by attaching it to the object structure and then accepting a visitor.
        /// </summary>
        /// <param name="element">The element to visit.</param>
        private static void VisitElement(IElement element)
        {
            _objectStructure.Attach(element);
            _objectStructure.Accept(_visitor);
        }
    }
}
