namespace AIDescriptions.Web.Services;

public interface IChatService
{
    Task<string> GetResponse(string promptInput);
}
