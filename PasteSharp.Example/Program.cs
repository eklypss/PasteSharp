using System;
using System.Threading.Tasks;
using PasteSharp.Enums;

namespace PasteSharp.Example
{
    internal class Program
    {
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            // Create new PasteSharpClient
            var client = new PasteSharpClient("api-key");

            // Create a paste, the CreatePasteAsync function returns a string which is the URL of the
            // newly created paste.
            Console.WriteLine(await client.CreatePasteAsync("Example paste", Publicity.Unlisted, DateTime.Now.ToString()));
            // returns: https://pastebin.com/UVqjnRkE (probably expired as of now)
            await Task.Delay(-1);
        }
    }
}