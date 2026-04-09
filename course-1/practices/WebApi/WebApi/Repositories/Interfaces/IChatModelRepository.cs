using Microsoft.AspNetCore.Identity.Data;
using WebApi.Repositories.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IChatModelRepository
    {
        Task<List<OpenApiResponse.Message>> GetHistoryAsync(long chatId);
        Task AddMessageAsync(long chatId, OpenApiResponse.Message message);
    }
}