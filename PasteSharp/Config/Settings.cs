namespace PasteSharp.Config
{
    public static class Settings
    {
        /// <summary>
        /// URL to send the POST request to.
        /// </summary>
        public static string PostUrl { get; set; } = "https://pastebin.com/api/api_post.php";
    }
}