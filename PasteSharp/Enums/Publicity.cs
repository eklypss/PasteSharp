using System;

namespace PasteSharp.Enums
{
    /// <summary>
    /// Determines who is available to view the paste.
    /// </summary>
    [Flags]
    public enum Publicity
    {
        Public,
        Unlisted,
        Private
    }
}