using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PasteSharp.Config;
using PasteSharp.Enums;

namespace PasteSharp.Services
{
    public class PasteService
    {
        private static HttpClient Http = new HttpClient();

        public async Task<string> CreatePasteAsync(string apiKey, string content, Publicity publicity, string title)
        {
            var post = new List<KeyValuePair<string, string>>();
            post.Add(new KeyValuePair<string, string>("api_dev_key", apiKey));
            post.Add(new KeyValuePair<string, string>("api_option", "paste"));
            post.Add(new KeyValuePair<string, string>("api_paste_code", content));
            post.Add(new KeyValuePair<string, string>("api_paste_name", title));
            post.Add(new KeyValuePair<string, string>("api_paste_private", GetPublicityInt(publicity).ToString()));

            using (var postContent = new FormUrlEncodedContent(post))
            {
                var result = await Http.PostAsync(Settings.PostUrl, postContent).ConfigureAwait(false);
                return await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        public int GetPublicityInt(Publicity publicity)
        {
            return (int)publicity;
        }
    }
}