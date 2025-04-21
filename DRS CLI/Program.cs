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


            Console.WriteLine("Hello, World!");


            while (isRunning)
            {
                // Console.Clear();
                Menu.PrintMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(await ApiHelper.GetDriverStandings());
                        Console.ResetColor();

                        Console.WriteLine(" ");

                        Menu.PrintNavigationMenu(out isRunning);
                        break;

                    case "2":
                         Console.Clear();
                        ;
                        Console.WriteLine("choice");
                        Menu.PrintNavigationMenu(out isRunning);
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
