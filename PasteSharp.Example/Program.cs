using System;
using System.Threading.Tasks;
using PasteSharp.Config;

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
            Console.WriteLine(await client.CreatePasteAsync("Example paste", false, DateTime.Now.ToString(), ExpireTime.Never));
            // returns: https://pastebin.com/g514v8u9

            // You can dispose the PasteSharpClient after you're done using it. You can also use the
            // "using" keyword to simplify this.
            client.Dispose();

            await Task.Delay(-1);
        }
    }
}