using Microsoft.AspNetCore.Mvc;
using WebApi.Repositories.Interfaces;
using WebApi.Repositories.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatTestController(IChatApiClient chatApiClient): ControllerBase
    {
        [HttpPost("test")]
        public async Task<IActionResult> Test([FromBody] ChatTestRequest request)
        {
            var history = new List<OpenApiResponse.Message>();
            var answer = await chatApiClient.SendMessageAsync(request.Message, history);
            return Ok(new { answer });
        }
    }
    public record ChatTestRequest(string Message);
}
