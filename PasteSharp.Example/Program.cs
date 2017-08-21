using System;
using System.Threading.Tasks;

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
            var client = new PasteSharpClient("043334c0ff604b6662097fafd334ba86");

            // Create a paste, the CreatePasteAsync function returns a string which is the URL of the
            // newly created paste.
            Console.WriteLine(await client.CreatePasteAsync("Example paste", false, DateTime.Now.ToString()));
            // returns: https://pastebin.com/g514v8u9 (probably expired as of now)

            // Just in case, you can dispose the PasteSharpClient. You can also use the "using"
            // keyword to simplify this.
            client.Dispose();

            await Task.Delay(-1);
        }
    }
}