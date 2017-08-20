using System.Threading.Tasks;

namespace PasteSharp
{
    public interface IPasteSharpClient
    {
        Task<string> CreatePasteAsync(string content, string title);
    }
}