using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class MessageSpammer
    {
        public static void Spam()
        {
            int Success = 0;
            int Errors = 0;

            Console.Clear();

            Console.Write("Channel ID: ");

            var ChannelID = Console.ReadLine();

            Console.Clear();

            Console.Write("Message: ");

            var Message = Console.ReadLine();

            Console.Clear();

            NameValueCollection nvc = new NameValueCollection();

            while(true)
            {
                foreach(string token in File.ReadAllLines("config/valid-tokens.txt"))
                {
                    if(token != null)
                    {
                        try
                        {
                            using(var wClient = new WebClient())
                            {
                                var random = new Random();
                                string MessageID = string.Empty;
                                for (int i = 0; i < 18; i++)
                                    MessageID = string.Concat(MessageID, random.Next(10).ToString());

                                wClient.Headers.Set("Authorization", token);

                                nvc["content"] = Message;
                                nvc["nonce"] = MessageID;
                                nvc["tts"] = "false";

                                wClient.UploadValues("https://discord.com/api/v8/channels/" + ChannelID + "/messages", nvc);

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkCyan;

                                Console.WriteLine("\n[Unix] Successfully Sent: " + Success);

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n[Unix] Unsuccessfully Sent: " + Errors);

                                Success++;
                            }
                        }
                        catch(Exception)
                        {
                            Errors++;

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("\n[Unix] Successfully Sent: " + Success);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n[Unix] Unsuccessfully Sent: " + Errors);
                        }
                    }
                }
            }
        }
    }
}