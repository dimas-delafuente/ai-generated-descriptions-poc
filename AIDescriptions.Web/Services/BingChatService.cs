using BingChat;

namespace AIDescriptions.Web.Services;

public class BingChatService : IChatService
{
    private readonly BingChatClient _client;

    public BingChatService()
    {
        _client = new BingChatClient(new BingChatClientOptions
        {
            // Tone used for conversation
            Tone = BingChatTone.Balanced,
            CookieFilePath = @"C:\Users\Dimas.delaFuente\Desktop\cookies.json"
        });
    }

    public async Task<string> GetResponse(string promptInput)
    {
        var response = await _client.AskAsync(promptInput).ConfigureAwait(false);

        return response;
    }
}
