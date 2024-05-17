using Structural.Decorator.Component;
using Structural.Decorator.ConcreteComponent;
using Structural.Decorator.Decorator;

namespace Structural.Decorator
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
            Console.WriteLine("Decorator pattern");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Enviar notificaciones general");
            Console.WriteLine("2. Enviar notificación por sms");
            Console.WriteLine("3. Enviar notificación por facebook");
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
                    SendAllNotifications();
                    break;
                case "2":
                    SendSmsNotification(new EmailNotifier());
                    break;
                case "3":
                    SendFacebookNotification(new EmailNotifier());
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
        /// Sends SMS notifications using an email notifier.
        /// </summary>
        private static void SendAllNotifications()
        {
            SendSmsNotification(new EmailNotifier());
            SendFacebookNotification(new EmailNotifier());
        }

        /// <summary>
        /// Sends an SMS notification using the specified notifier.
        /// </summary>
        /// <param name="notifier">The notifier to use.</param>
        private static void SendSmsNotification(INotifier notifier)
        {
            notifier = new SMSNotifier(notifier);
            notifier.Send("Hello, World by sms!");
        }

        /// <summary>
        /// Sends a Facebook notification using the specified notifier.
        /// </summary>
        /// <param name="notifier">The notifier to use.</param>
        private static void SendFacebookNotification(INotifier notifier)
        {
            notifier = new FacebookNotifier(notifier);
            notifier.Send("Hello, World by facebook!");
        }
    }
}
