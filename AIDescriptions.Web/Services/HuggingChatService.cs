using System.Text;
using System.Text.Json;

namespace AIDescriptions.Web.Services;

public class HuggingChatService : IChatService
{
    private readonly HttpClient _client;

    public HuggingChatService(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetResponse(string promptInput)
    {
        using StringContent jsonContent = new(
            JsonSerializer.Serialize(new
            {
                prompt = promptInput
            }),
            Encoding.UTF8,
            "application/json");

        var response = await _client.PostAsync("/prompts", jsonContent).ConfigureAwait(false);
        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }
}
