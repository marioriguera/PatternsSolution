using Behavior.Command.Commands;
using Behavior.Command.Invokers;
using Behavior.Command.Receivers;

namespace Behavior.Command
{
    /// <summary>
    /// Main class where the application starts.
    /// </summary>
    internal class Program
    {
        private static readonly RemoteControl _remote = new();
        private static readonly Light _livingRoomLight = new();
        private static readonly ICommand _lightOn;
        private static readonly ICommand _lightOff;

        /// <summary>
        /// Initializes static members of the <see cref="Program"/> class.
        /// </summary>
        static Program()
        {
            _lightOn = new LightOnCommand(_livingRoomLight);
            _lightOff = new LightOffCommand(_livingRoomLight);
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
            Console.WriteLine("Command pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Oprimir botón de encender luz");
            Console.WriteLine("2. Oprimir botón de apagar luz");
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
                    PushTurnOnTheLight();
                    break;
                case "2":
                    PushTurnOffTheLight();
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
        /// Sets the remote control command to turn on the light and presses the button.
        /// </summary>
        private static void PushTurnOnTheLight()
        {
            _remote.SetCommand(_lightOn);
            _remote.PressButton();
        }

        /// <summary>
        /// Sets the remote control command to turn off the light and presses the button.
        /// </summary>
        private static void PushTurnOffTheLight()
        {
            _remote.SetCommand(_lightOff);
            _remote.PressButton();
        }
    }
}
