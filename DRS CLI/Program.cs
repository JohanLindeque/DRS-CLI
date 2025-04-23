using System.Threading.Tasks;
using DRS_CLI.Utilities;
using JolpiF1Library;
using JolpiF1Library.Utilities;

namespace DRS_CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isRunning = true;
            ApiHelper.InitializeClient();
            Console.WindowWidth = 150;
            Console.WindowHeight = 40;

            while (isRunning)
            {
                
                Menu.PrintMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Menu.PrintLogo();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Current Driver Standings:");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(await ApiHelper.GetDriverStandings());
                        Console.ResetColor();

                        Menu.PrintNavigationMenu(out isRunning);
                        break;

                    case "2":
                        Console.Clear();
                        Menu.PrintLogo();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Current Constructor Standings:");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(await ApiHelper.GetConstructorStandings());
                        Console.ResetColor();

                        Menu.PrintNavigationMenu(out isRunning);
                        break;

                    case "3":
                        Console.Clear();
                        Menu.PrintLogo();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Current Race Calendar:");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(await ApiHelper.GetSeasonRaces());
                        Console.ResetColor();

                        Menu.PrintNavigationMenu(out isRunning);
                        break;

                    case "E":
                        isRunning = false;
                        break;

                    default:
                        break;
                }

            }


            Console.WriteLine("Good bye.");
            Console.ReadKey();
        }
    }
}
