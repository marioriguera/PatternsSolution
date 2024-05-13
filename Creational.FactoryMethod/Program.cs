namespace Creational.FactoryMethod
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
                    CreateProdctA();
                    break;
                case "2":
                    CreateProductB();
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
        /// Get option menu console.
        /// </summary>
        private static void GetOption()
        {
            Console.WriteLine("Factory Method pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Obtener producto A");
            Console.WriteLine("2. Obtener producto B");
            Console.WriteLine("3. Salir");
        }

        /// <summary>
        /// Creates Product A.
        /// </summary>
        private static void CreateProdctA()
        {
            Console.WriteLine("Ha seleccionado la Opción 1.");

            Creator creator = new ConcreteCreatorA();
            IProduct product = creator.FactoryMethod();

            Console.WriteLine("Entonces se ha creado el producto A.");
        }

        /// <summary>
        /// Creates Product B.
        /// </summary>
        private static void CreateProductB()
        {
            Console.WriteLine("Ha seleccionado la Opción 2.");

            Creator creator = new ConcreteCreatorB();
            IProduct product = creator.FactoryMethod();

            Console.WriteLine("Entonces se ha creado el producto B.");
        }
    }
}
