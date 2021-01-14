using System;
using System.IO;
using System.Linq;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class GenerateTokens
    {
        public static void Generate()
        {
            try
            {
                Console.Clear();

                Int64 amount = 0;
                Int64 generated = 0;

                Console.Write("How any token's would you like to generate?\n\n>");

                var inputAmount = Console.ReadLine();

                amount = Int64.Parse(inputAmount);

                Console.Clear();

                while(true)
                {
                    if(generated == amount)
                    {
                        break;
                    }
                    else
                    {
                        using(StreamWriter sw = File.AppendText("config/generated-tokens.txt"))
                        {
                            string token = $"Nz{RandomString(22)}.{RandomString(1)}_{RandomString(4)}.{RandomString(27)}";

                            sw.WriteLine(token);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine($"[Unix] Token: {token}");
                        }
                    }

                    generated++;
                }
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[Unix] There was an error");

                Console.ReadKey();

                Program.Menu();
            }
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}