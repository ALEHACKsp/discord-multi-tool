using System;
using System.Net;
using System.Threading;

namespace Unix_Coding_Discord_Multi_Tool.functions.Self_Bot
{
    class StatusChanger
    {
        public static void ChangeStatus()
        {
            Console.Clear();

            string token;
            string status1;
            string status2;
            string status3;

            Console.Write("Your Token: ");

            token = Console.ReadLine();

            Console.Clear();

            Console.Write("Status Part 1: ");

            status1 = Console.ReadLine();

            Console.Clear();

            Console.Write("Status Part 2: ");

            status2 = Console.ReadLine();

            Console.Clear();

            Console.Write("Status Part 3: ");

            status3 = Console.ReadLine();

            Console.Clear();

            while(true)
            {
                try
                {
                    using(var wClient = new WebClient())
                    {
                        wClient.Headers.Set("Authorization", token);
                        wClient.Headers.Set("Content-Type", "application/json");
                        wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", "{\"custom_status\": {\"text\":\"" + status1 + "\"}}");

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("Set Status: " + status1);

                        Thread.Sleep(3000);

                        wClient.Headers.Set("Authorization", token);
                        wClient.Headers.Set("Content-Type", "application/json");
                        wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", "{\"custom_status\": {\"text\":\"" + status2 + "\"}}");

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("Set Status: " + status2);

                        Thread.Sleep(3000);

                        wClient.Headers.Set("Authorization", token);
                        wClient.Headers.Set("Content-Type", "application/json");
                        wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", "{\"custom_status\": {\"text\":\"" + status3 + "\"}}");

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("Set Status: " + status3);

                        Thread.Sleep(3000);
                    }
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("[Unix] There was an error");
                }
            }
        }
    }
}