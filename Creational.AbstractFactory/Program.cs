namespace Creational.AbstractFactory
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
            Console.WriteLine("Abstract Factory pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Obtener producto A1");
            Console.WriteLine("2. Obtener producto A2");
            Console.WriteLine("3. Obtener producto B1");
            Console.WriteLine("4. Obtener producto B2");
            Console.WriteLine("5. Salir");
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
                    CreateProductA1();
                    break;
                case "2":
                    CreateProductA2();
                    break;
                case "3":
                    CreateProductB1();
                    break;
                case "4":
                    CreateProductB2();
                    break;
                case "5":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            return exitRequested;
        }

        /// <summary>
        /// Creates Product A1.
        /// </summary>
        private static void CreateProductA1()
        {
            Console.WriteLine("Ha seleccionado la Opción 1.");

            IAbstractFactory factory = new ConcreteFactory();
            _ = factory.CreateProductA("A1");

            Console.WriteLine("Entonces se ha creado el producto A1.");
        }

        /// <summary>
        /// Creates Product A2.
        /// </summary>
        private static void CreateProductA2()
        {
            Console.WriteLine("Ha seleccionado la Opción 2.");

            IAbstractFactory factory = new ConcreteFactory();
            _ = factory.CreateProductA("A2");

            Console.WriteLine("Entonces se ha creado el producto A2.");
        }

        /// <summary>
        /// Creates Product B1.
        /// </summary>
        private static void CreateProductB1()
        {
            Console.WriteLine("Ha seleccionado la Opción 3.");

            IAbstractFactory factory = new ConcreteFactory();
            _ = factory.CreateProductB("B1");

            Console.WriteLine("Entonces se ha creado el producto B1.");
        }

        /// <summary>
        /// Creates Product B2.
        /// </summary>
        private static void CreateProductB2()
        {
            Console.WriteLine("Ha seleccionado la Opción 4.");

            IAbstractFactory factory = new ConcreteFactory();
            _ = factory.CreateProductB("B2");

            Console.WriteLine("Entonces se ha creado el producto B2.");
        }
    }
}