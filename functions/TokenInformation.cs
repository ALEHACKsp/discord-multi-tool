using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace Unix_Coding_Discord_Multi_Tool.functions
{
    class TokenInformation
    {
        public static void GetInformation()
        {
            Console.Write("Token: ");

            var token = Console.ReadLine();

            Console.Clear();

            try
            {
                using(var wClient = new WebClient())
                {
                    wClient.Headers.Set("Authorization", token);

                    var response = wClient.DownloadString("https://discord.com/api/v8/users/@me");

                    JObject parsed = JObject.Parse(response);

                    string UserID = parsed["id"].ToString();
                    string Username = parsed["username"].ToString();
                    string Avatar = parsed["avatar"].ToString();
                    string Discriminator = parsed["discriminator"].ToString();
                    string PublicFlags = parsed["public_flags"].ToString();
                    string Flags = parsed["flags"].ToString();
                    string Email = parsed["email"].ToString();
                    string Verified = parsed["verified"].ToString();
                    string Locale = parsed["locale"].ToString();
                    string NSFWAllowed = parsed["nsfw_allowed"].ToString();
                    string MFAEnabled = parsed["mfa_enabled"].ToString();
                    string Phone = parsed["phone"].ToString();

                    if(Phone == "")
                    {
                        Phone = "null";
                    }

                    if(Avatar == "")
                    {
                        Avatar = "null";
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine("User ID: " + UserID + "\nUsername: " + Username + "\nAvatar: " + "https://cdn.discordapp.com/avatars/" + UserID + "/" + Avatar + ".png?size=256" + "\nDiscriminator: " + Discriminator + "\nPublic Flags: " + PublicFlags + "\nFlags: " + Flags + "\nE-Mail: " + Email + "\nVerified: " + Verified + "\nLocale: " + Locale + "\nNSFW Allowed: " + NSFWAllowed + "\nMFA Enabled: " + MFAEnabled + "\nPhone: " + Phone);
                }
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("[Unix] Invalid Token");
            }

            Console.ReadKey();

            Program.Menu();
        }
    }
}