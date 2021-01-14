using System;
using Unix_Coding_Discord_Multi_Tool.functions;
using Unix_Coding_Discord_Multi_Tool.functions.Self_Bot;

namespace Unix_Coding_Discord_Multi_Tool
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Unix Coding | Discord Multi-Tool | Home";

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Menu();

            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Clear();

            Console.WriteLine("\n\n                     ██╗░░░██╗███╗░░██╗██╗██╗░░██╗  ░█████╗░░█████╗░██████╗░██╗███╗░░██╗░██████╗░");
            Console.WriteLine("                     ██║░░░██║████╗░██║██║╚██╗██╔╝  ██╔══██╗██╔══██╗██╔══██╗██║████╗░██║██╔════╝░");
            Console.WriteLine("                     ██║░░░██║██╔██╗██║██║░╚███╔╝░  ██║░░╚═╝██║░░██║██║░░██║██║██╔██╗██║██║░░██╗░");
            Console.WriteLine("                     ██║░░░██║██║╚████║██║░██╔██╗░  ██║░░██╗██║░░██║██║░░██║██║██║╚████║██║░░╚██╗");
            Console.WriteLine("                     ╚██████╔╝██║░╚███║██║██╔╝╚██╗  ╚█████╔╝╚█████╔╝██████╔╝██║██║░╚███║╚██████╔╝");
            Console.WriteLine("                     ░╚═════╝░╚═╝░░╚══╝╚═╝╚═╝░░╚═╝  ░╚════╝░░╚════╝░╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░");

            Console.WriteLine("\n                                   ==============================================");
            Console.WriteLine("                                   [1] Token Information   [2] Message Spammer");
            Console.WriteLine("                                   [3] Server Joiner       [4] Server Leaver");
            Console.WriteLine("                                   [5] Spam Joiner         [6] Destroy Account");
            Console.WriteLine("                                   [7] Settings            [8] Token Checker");
            Console.WriteLine("                                   [9] Generate Tokens     [10] Webhook Spammer");
            Console.WriteLine("                                   [11] Generate Nitro     [12] Nitro Checker");
            Console.WriteLine("                                   [13] Exit");
            Console.WriteLine("                                   ==============================================\n");
            Console.Write(">");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();

                    TokenInformation.GetInformation();
                    break;

                case "2":
                    Console.Clear();

                    MessageSpammer.Spam();
                    break;

                case "3":
                    Console.Clear();

                    ServerJoiner.Join();
                    break;

                case "4":
                    Console.Clear();

                    ServerLeaver.Leave();
                    break;

                case "5":
                    Console.Clear();

                    SpamJoiner.Join();
                    break;

                case "6":
                    Console.Clear();

                    DestroyAccount.Start();
                    break;

                case "7":
                    Settings.Menu();
                    break;

                case "8":
                    TokenChecker.Check();
                    break;

                case "9":
                    GenerateTokens.Generate();
                    break;

                case "10":
                    WebhookSpammer.Spam();
                    break;

                case "11":
                    GenerateNitro.Generate();
                    break;

                case "12":
                    NitroChecker.Check();
                    break;

                case "13":
                    Environment.Exit(0);
                    break;

                case "69":
                    StatusChanger.ChangeStatus();
                    break;
            }
        }
    }
}