using System;
using System.Diagnostics;

namespace Unix_Coding_Discord_Multi_Tool
{
    class Settings
    {
        public static void Menu()
        {
            Console.Clear();

            Console.Title = "Unix Coding | Discord Multi-Tool | Settings";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("░██████╗███████╗████████╗████████╗██╗███╗░░██╗░██████╗░░██████╗");
            Console.WriteLine("██╔════╝██╔════╝╚══██╔══╝╚══██╔══╝██║████╗░██║██╔════╝░██╔════╝");
            Console.WriteLine("╚█████╗░█████╗░░░░░██║░░░░░░██║░░░██║██╔██╗██║██║░░██╗░╚█████╗░");
            Console.WriteLine("░╚═══██╗██╔══╝░░░░░██║░░░░░░██║░░░██║██║╚████║██║░░╚██╗░╚═══██╗");
            Console.WriteLine("██████╔╝███████╗░░░██║░░░░░░██║░░░██║██║░╚███║╚██████╔╝██████╔╝");
            Console.WriteLine("╚═════╝░╚══════╝░░░╚═╝░░░░░░╚═╝░░░╚═╝╚═╝░░╚══╝░╚═════╝░╚═════╝░");

            Console.WriteLine("\n[1] Credits");
            Console.WriteLine("[2] Discord");
            Console.WriteLine("[3] Home");
            Console.Write("\n>");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Credits();
                    break;

                case "2":
                    Discord();
                    break;

                case "3":
                    Program.Menu();
                    break;
            }
        }

        public static void Credits()
        {
            Console.Clear();

            Console.WriteLine("This Application Was Coded By: G4 Aqua, All API Data Was Collected By Aqua.");

            Console.WriteLine("\n[1] Settings");
            Console.WriteLine("[2] Home");
            Console.Write("\n>");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Menu();
                    break;

                case "2":
                    Program.Menu();
                    break;
            }

        }

        public static void Discord()
        {
            Process.Start("https://discord.gg/tEVQA8zHNZ");
        }
    }
}