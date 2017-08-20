using System.Threading.Tasks;
using PasteSharp.Interfaces;
using PasteSharp.Services;

namespace PasteSharp
{
    public class PasteSharpClient : IPasteSharpClient
    {
        private readonly PasteService _pasteService;
        private readonly string _apiKey;

        public PasteSharpClient(string apiKey)
        {
            _apiKey = apiKey;
            _pasteService = new PasteService();
        }

        public async Task<string> CreatePasteAsync(string content, string title = "Untitled")
        {
            return await _pasteService.CreatePasteAsync(_apiKey, title, content).ConfigureAwait(false);
        }
    }
}