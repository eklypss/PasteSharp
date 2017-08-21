using System;
using System.Threading.Tasks;
using PasteSharp.Config;
using PasteSharp.Interfaces;
using PasteSharp.Services;

namespace PasteSharp
{
    public class PasteSharpClient : IPasteSharpClient, IDisposable
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
        /// <param name="title">Title of the paste.</param>
        /// <param name="unlisted">Whether the paste will be unlisted or not.</param>
        /// <param name="expire">Duration until the paste expires.</param>
        /// <returns>URL to the paste as a string.</returns>
        public async Task<string> CreatePasteAsync(string content, bool unlisted = false, string title = "Untitled", string expire = ExpireTime.Never)
        {
            return await _pasteService.CreatePasteAsync(_apiKey, title, unlisted, content, expire).ConfigureAwait(false);
        }

        public void Dispose()
        {
            _pasteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}