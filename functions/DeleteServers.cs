using System;
using System.Net;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class DeleteServers
    {
        public static void Delete()
        {
            string token;

            try
            {
                Console.Clear();

                Console.Write("Token: ");

                token = Console.ReadLine();

                using(var wClient = new WebClient())
                {
                    wClient.Headers.Set("Authorization", token);
                    wClient.Headers.Set("Content-Type", "application/json");
                    var profileResponse = wClient.DownloadString("https://discord.com/api/v8/users/@me/settings");

                    Console.WriteLine(profileResponse);
                }

            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[Unix] There was an error deleting the requested server");
            }
        }
    }
}