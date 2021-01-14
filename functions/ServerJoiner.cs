using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class ServerJoiner
    {
        public static void Join()
        {
            Console.Clear();

            Console.Write("Invite ID: ");

            var InviteID = Console.ReadLine();

            Console.Clear();

            foreach(string token in File.ReadAllLines("config/valid-tokens.txt"))
            {
                if(token != null)
                {
                    try
                    {
                        using(var wClient = new WebClient())
                        {
                            wClient.Headers.Set("Authorization", token);

                            wClient.UploadValues($"https://discord.com/api/v8/invites/{InviteID}", new NameValueCollection());

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("[Unix] Successfully Joined Server");
                        }
                    }
                    catch(Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("[Unix] There Was An Error While Joining The Server");
                    }
                }
            }

            Console.ReadKey();

            Program.Menu();
        }
    }
}