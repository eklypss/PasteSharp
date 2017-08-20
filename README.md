[![NuGet version](https://badge.fury.io/nu/PasteSharpCore.svg)](https://badge.fury.io/nu/PUBGSharp)
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
    Console.WriteLine(await client.CreatePasteAsync("Example paste", Publicity.Unlisted, DateTime.Now.ToString()));
    // returns: https://pastebin.com/UVqjnRkE (probably expired as of now)
    await Task.Delay(-1);
}
```

## Install
To add PasteSharp to your project, run the following command in the NuGet package manager:

``Install-Package PasteSharpCore``

## Getting API key
Register to Pastebin and head to https://pastebin.com/api - your API key should be visible there.
