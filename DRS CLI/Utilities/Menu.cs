using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRS_CLI.Utilities
{
    public static class Menu
    {
        
        public static void PrintMainMenu()
        {
             Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Driver Standings");
            Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            Console.WriteLine("Enter option:");
        }

        public static void PrintNavigationMenu(out bool isRunning)
        {
            isRunning = true;
            Console.WriteLine(" ");
            Console.WriteLine("Navigation menu");
            Console.WriteLine("1 back");
            Console.WriteLine("2 exit");
            Console.WriteLine("Enter option:");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    isRunning = true;
                    break;

                case "2":
                    isRunning = false;
                    break;

                default:
                    break;
            }

        }
    }
}
