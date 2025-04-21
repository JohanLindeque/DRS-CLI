using DRS_CLI.Utilities;

namespace DRS_CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Menu menu = new Menu();


            Console.WriteLine("Hello, World!");


            while (isRunning)
            {
                Console.Clear();
                menu.PrintMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("choice");
                        Console.WriteLine(" ");
                        menu.PrintNavigationMenu(out isRunning);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("choice");
                        menu.PrintNavigationMenu(out isRunning);
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
