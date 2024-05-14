namespace Creational.Builder
{
    /// <summary>
    /// Represents the entry point of the program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
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
            Console.WriteLine("Builder pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Contruir un producto");
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
                    // Create a concrete builder
                    IBuilder builder = new ConcreteBuilder();

                    // Create a director and pass the builder to it
                    Director director = new(builder);

                    // Construct the product
                    director.Construct();

                    // Get the constructed product
                    Product product = builder.GetResult();

                    // Show the product information
                    product.ShowInfo();
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
    }
}
