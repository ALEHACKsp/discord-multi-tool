using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class TokenChecker
    {
        public static void Check()
        {
            new Thread(() =>
            {
                try
                {
                    Console.Clear();

                    int validTokens = 0;
                    int invalidTokens = 0;

                    string currentPath = Directory.GetCurrentDirectory();

                    foreach(string token in File.ReadAllLines("config/generated-tokens.txt"))
                    {
                        if(token != null)
                        {
                            try
                            {
                                using(var wClient = new WebClient())
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;

                                    wClient.Headers.Set("Authorization", token);
                                    wClient.DownloadString("https://discord.com/api/v8/users/@me");

                                    Console.Clear();

                                    validTokens++;

                                    using(StreamWriter sw = File.AppendText("config/valid-tokens.txt"))
                                    {
                                        sw.WriteLine(token);
                                    }

                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine($"[Valid Tokens: {validTokens}]");

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"[Invalid Tokens: {invalidTokens}]");
                                }
                            }
                            catch(Exception)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                invalidTokens++;

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"[Valid Tokens: {validTokens}]");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"[Invalid Tokens: {invalidTokens}]");
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