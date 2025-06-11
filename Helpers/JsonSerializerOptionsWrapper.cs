using System.Text.Json;

namespace HttpClientUsageAPI.Helpers;

// Taken from https://github.com/KevinDockx/AccessingApisWithHttpClient/blob/main/Finished%20sample/Movies.Client/Helpers/JsonSerializerOptionsWrapper.cs
public class JsonSerializerOptionsWrapper
{
    public JsonSerializerOptions Options { get; }

    public JsonSerializerOptionsWrapper()
    {
        Options = new JsonSerializerOptions(
            JsonSerializerDefaults.Web);

        Options.DefaultBufferSize = 10;
    }
}
