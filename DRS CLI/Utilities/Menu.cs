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
            PrintLogo();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Driver Standings this season");
            Console.WriteLine("2. Constructor Standings this season");
            Console.WriteLine("3. Race calendar this season");

            Console.WriteLine("E. Exit");
            Console.WriteLine("Enter option:");
            Console.ResetColor();

        }

        public static void PrintNavigationMenu(out bool isRunning)
        {
            isRunning = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ");
            Console.WriteLine("Navigation menu");
            Console.WriteLine("1. Back");
            Console.WriteLine("E. Exit");
            Console.WriteLine("Enter option:");
            Console.ResetColor();

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    isRunning = true;
                    break;

                case "E":
                    isRunning = false;
                    break;

                default:
                    break;
            }

        }

        public static void PrintLogo()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"        __/\\\\\\\\\\\\_______/\\\\\\\\\_________/\\\\\\\\\\\____________________/\\\\\\\\\__/\\\______________/\\\\\\\\\\\___________         ");
            Console.WriteLine(@"         _\/\\\////////\\\___/\\\///////\\\_____/\\\/////////\\\_______________/\\\////////__\/\\\_____________\/////\\\///____________        ");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"          _\/\\\______\//\\\_\/\\\_____\/\\\____\//\\\______\///______________/\\\/___________\/\\\_________________\/\\\_______________       ");
            Console.WriteLine(@"           _\/\\\_______\/\\\_\/\\\\\\\\\\\/______\////\\\____________________/\\\_____________\/\\\_________________\/\\\_______________      ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"            _\/\\\_______\/\\\_\/\\\//////\\\_________\////\\\________________\/\\\_____________\/\\\_________________\/\\\_______________     ");
            Console.WriteLine(@"             _\/\\\_______\/\\\_\/\\\____\//\\\___________\////\\\_____________\//\\\____________\/\\\_________________\/\\\_______________    ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"              _\/\\\_______/\\\__\/\\\_____\//\\\___/\\\______\//\\\_____________\///\\\__________\/\\\_________________\/\\\_______________   ");
            Console.WriteLine(@"               _\/\\\\\\\\\\\\/___\/\\\______\//\\\_\///\\\\\\\\\\\/________________\////\\\\\\\\\_\/\\\\\\\\\\\\\\\__/\\\\\\\\\\\___________  ");
            Console.WriteLine(@"                _\////////////_____\///________\///____\///////////_____________________\/////////__\///////////////__\///////////____________ ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                                                               By Johan Lindeque");

            Console.ResetColor();
        }
    }
}
