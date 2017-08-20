using System.Threading.Tasks;
using PasteSharp.Enums;

namespace PasteSharp.Interfaces
{
    public interface IPasteSharpClient
    {
        Task<string> CreatePasteAsync(string content, Publicity publicity, string title);
    }
}