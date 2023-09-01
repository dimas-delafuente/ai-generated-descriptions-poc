using OpenAI_API;

namespace AIDescriptions.Web.Services;

public class ChatGPTService : IChatService
{
    private readonly IOpenAIAPI _client;

    public ChatGPTService()
    {
        _client = new OpenAIAPI("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"); // shorthand
    }

    public async Task<string> GetResponse(string input)
    {
        var chat = _client.Chat.CreateConversation();

        /// give instruction as System
        chat.AppendSystemMessage("You are a marketing expert for e-commerce sellers, who is specialized in writing product descriptions. Sellers will ask you to write product descriptions and you will generate one for them, just replying with the description you built.");

        // now let's ask it a question'
        chat.AppendUserInput(input);
        // and get the response
        string response = await chat.GetResponseFromChatbotAsync();
        Console.WriteLine(response); // "Yes"

        return response;
    }
}
