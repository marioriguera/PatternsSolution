using System;

namespace Behavior.Observer
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static readonly ConcreteSubject _subject = new();
        private static readonly ConcreteObserver _observer1 = new("Observer 1");
        private static readonly ConcreteObserver _observer2 = new("Observer 2");

        /// <summary>
        /// Initializes static members of the <see cref="Program"/> class.
        /// </summary>
        static Program()
        {
            _subject.Attach(_observer1);
            _subject.Attach(_observer2);
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
            Console.WriteLine("Observer pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Cambiar estados a observadores");
            Console.WriteLine("2. Eliminar observador 1 y cambiar estado");
            Console.WriteLine("3. Eliminar observador 2 y cambiar estado");
            Console.WriteLine("4. Saber los observadores que tengo");
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
                    ChangeState("State A");
                    ChangeState("State B");
                    break;
                case "2":
                    RemoveObserver(_observer1);
                    ChangeState("State C");
                    break;
                case "3":
                    RemoveObserver(_observer2);
                    ChangeState("State D");
                    break;
                case "4":
                    PrintObservers();
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
        /// Changes the state of the subject, which will notify all attached observers.
        /// </summary>
        /// <param name="state">The new state to set.</param>
        private static void ChangeState(string state)
        {
            _subject.State = state;
        }

        /// <summary>
        /// Detaches an observer from the subject so it will no longer receive updates.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        private static void RemoveObserver(ConcreteObserver observer)
        {
            _subject.Detach(observer);
        }

        /// <summary>
        /// Prints the names of all currently attached observers.
        /// </summary>
        private static void PrintObservers()
        {
            Console.WriteLine(string.Join(',', _subject.Observers.Select(o => o.Name).ToList()));
        }
    }
}
