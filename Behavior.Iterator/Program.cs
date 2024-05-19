using Behavior.Iterator.Aggregates;

namespace Behavior.Iterator
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
            Console.WriteLine("Iterator pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Iterar sobre arreglo de enteros");
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
                    IterateExample();
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
        /// Example of iterating over a collection of numbers.
        /// </summary>
        private static void IterateExample()
        {
            // Collection of numbers
            int[] numbers = [1, 2, 3, 4, 5];
            Console.WriteLine($"Array de enteros a iterar: {string.Join(",", numbers)} .");

            // Create an aggregate
            var aggregate = new ConcreteAggregate<int>(numbers);

            // Create an iterator
            var iterator = aggregate.CreateIterator();

            // Iterate over the elements
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
