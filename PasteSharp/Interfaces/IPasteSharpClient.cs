using System.Threading.Tasks;

namespace PasteSharp.Interfaces
{
    public interface IPasteSharpClient
    {
        Task<string> CreatePasteAsync(string content, string title);
    }
}