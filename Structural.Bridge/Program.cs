namespace Structural.Bridge
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
            Console.WriteLine("Abstract Factory pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Renderizar círculo con líneas");
            Console.WriteLine("2. Renderizar círculo con píxeles");
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
            string input = Console.ReadLine() ?? "5";

            switch (input)
            {
                case "1":
                    RenderCircleWithLines();
                    break;
                case "2":
                    RenderCircleWithPixels();
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
        /// Renders a circle with pixels using a raster renderer and outputs the result.
        /// </summary>
        private static void RenderCircleWithPixels()
        {
            IRenderer rasterRenderer = new RasterRenderer();
            Shape circle = new Circle(rasterRenderer, 5);
            Console.WriteLine(circle.Draw()); // Output: Drawing a circle of radius 5 with pixels
        }

        /// <summary>
        /// Renders a circle with lines using a vector renderer and outputs the result.
        /// </summary>
        private static void RenderCircleWithLines()
        {
            IRenderer vectorRenderer = new VectorRenderer();
            Shape circle = new Circle(vectorRenderer, 5);
            Console.WriteLine(circle.Draw()); // Output: Drawing a circle of radius 5 with lines
        }
    }
}
