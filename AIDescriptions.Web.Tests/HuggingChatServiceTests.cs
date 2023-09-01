using AIDescriptions.Web.Samples;
using AIDescriptions.Web.Services;

namespace AIDescriptions.Tests;

public class HuggingChatServiceTests
{
    private readonly HuggingChatService _service;

    public HuggingChatServiceTests()
    {
        _service = new HuggingChatService(new HttpClient
        {
            BaseAddress = new("http://localhost:8083/")
        });
    }

    [Fact]
    public async Task Test1Async()
    {
        var prompt = PromptBuilder.FromItem(InventoryItemSamples.DrawerOrganizer, 1000);

        var promptResponse = await _service.GetResponse(prompt);

        Assert.NotNull(promptResponse);
    }
}