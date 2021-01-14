using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class NitroChecker
    {
        public static void Check()
        {
            new Thread(() =>
            {
                try
                {
                    Console.Clear();

                    int validGifts = 0;
                    int invalidGifts = 0;

                    string currentPath = Directory.GetCurrentDirectory();

                    foreach(string gifts in File.ReadAllLines("config/generated-nitro-codes.txt"))
                    {
                        if(gifts != null)
                        {
                            try
                            {
                                using(var wClient = new WebClient())
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    wClient.DownloadString($"https://discordapp.com/api/v6/entitlements/gift-codes/{gifts}?with_application=false&with_subscription_plan=true");

                                    Console.Clear();

                                    validGifts++;

                                    using(StreamWriter sw = File.AppendText("config/valid-nitro.txt"))
                                    {
                                        sw.WriteLine("discord.gift/" + gifts);
                                    }

                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"[Valid Gifts: {validGifts}]");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"[Invalid Gifts: {invalidGifts}]");
                                }
                            }
                            catch(Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                invalidGifts++;

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"[Valid Gifts: {validGifts}]");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"[Invalid Gifts: {invalidGifts}]");
                            }
                        }
                    }
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("[Unix] Try generating some tokens first");

                    Console.ReadKey();

                    Program.Menu();
                }
            }).Start();
        }
    }
}