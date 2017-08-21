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

        /// <summary>
        /// Creates a new paste.
        /// </summary>
        /// <param name="content">Content of the paste.</param>
        /// <param name="publicity"><see cref="Publicity"/> of the paste.</param>
        /// <param name="title">Title of the paste.</param>
        /// <returns>URL to the paste as a string.</returns>
        public async Task<string> CreatePasteAsync(string content, bool unlisted = false, string title = "Untitled")
        {
            return await _pasteService.CreatePasteAsync(_apiKey, title, unlisted, content).ConfigureAwait(false);
        }
    }
}