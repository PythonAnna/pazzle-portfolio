using WebApi.Repositories.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IChatApiClient
    {
        Task<string> SendMessageAsync(string userMessage, IEnumerable<OpenApiResponse.Message> history);
    }
}
