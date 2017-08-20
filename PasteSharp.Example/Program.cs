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
            var client = new PasteSharpClient("api-key");
            Console.WriteLine(await client.CreatePasteAsync("Example paste", Publicity.Unlisted, DateTime.Now.ToString()));

            await Task.Delay(-1);
        }
    }
}