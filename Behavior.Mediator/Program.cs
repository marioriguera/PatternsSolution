namespace Behavior.Mediator
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static readonly ConcreteMediator _mediator = new();
        private static readonly ColleagueA _colleagueA;
        private static readonly ColleagueB _colleagueB;

        static Program()
        {
            _colleagueA = new ColleagueA(_mediator);
            _colleagueB = new ColleagueB(_mediator);

            _mediator.ColleagueA = _colleagueA;
            _mediator.ColleagueB = _colleagueB;
        }

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
            Console.WriteLine("Mediator pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Enviar mensaje desde el amigo A hacia el B");
            Console.WriteLine("2. Enviar mensaje desde el amigo B hacia el A");
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
                    SendMessageBetweenTwoFriends(_colleagueA);
                    break;
                case "2":
                    SendMessageBetweenTwoFriends(_colleagueB);
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
        /// Sends a message from one colleague to another.
        /// </summary>
        /// <param name="start">The starting colleague.</param>
        private static void SendMessageBetweenTwoFriends(Colleague start)
        {
            switch (start)
            {
                case ColleagueA:
                    ((ColleagueA)start).SendMessage("Hello from Colleague A!");
                    break;
                case ColleagueB:
                    ((ColleagueB)start).SendMessage("Hello from Colleague B!");
                    break;
                default:
                    Console.WriteLine($"Unmanage {nameof(start)} type in {nameof(SendMessageBetweenTwoFriends)}. The type is {start?.GetType()}");
                    break;
            }
        }
    }
}
