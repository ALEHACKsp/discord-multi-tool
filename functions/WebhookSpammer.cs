using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class WebhookSpammer
    {
        public static void Spam()
        {
            try
            {
                Console.Clear();

                Console.Write("Message: ");

                var message = Console.ReadLine();

                Console.Clear();

                while(true)
                {
                    foreach(string webhook in File.ReadAllLines("config/webhooks.txt"))
                    {
                        try
                        {
                            using(var wClient = new WebClient())
                            {
                                NameValueCollection values = new NameValueCollection();

                                values["username"] = "Xyn Big Skid";
                                values["avatar_url"] = "https://th.bing.com/th/id/OIP.r8V3TVK8707ofTYj027DwQHaE8?pid=Api&rs=1";
                                values["content"] = message;

                                wClient.UploadValues(webhook, values);
                            }

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("[Unix] Sent message to webhook\n");
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("[Unix] Unable to send message to webhook\n");
                        }
                    }
                }
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[Unix] Unable to complete request\n");
            }
        }
    }
}