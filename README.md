[![NuGet version](https://badge.fury.io/nu/PasteSharpCore.svg)](https://badge.fury.io/nu/PasteSharpCore)
# PasteSharp
Lightweight .NET Core library for uploading pastes to Pastebin.

## Example

```
private static async Task MainAsync()
{
    // Create new PasteSharpClient
    var client = new PasteSharpClient("api-key");

    // Create a paste, the CreatePasteAsync function returns a string which is the URL of the
    // newly created paste.
    Console.WriteLine(await client.CreatePasteAsync("Example paste", false, DateTime.Now.ToString(), ExpireTime.Never));
    // returns: https://pastebin.com/g514v8u9

    // You can dispose the PasteSharpClient after you're done using it. You can also use the
    // "using" keyword to simplify this.
    client.Dispose();

    await Task.Delay(-1);
}
```

## Install
To add PasteSharp to your project, run the following command in the NuGet package manager:

``Install-Package PasteSharpCore``

## Getting API key
Register to Pastebin and head to https://pastebin.com/api - your API key should be visible there.
