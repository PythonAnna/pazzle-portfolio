using Microsoft.AspNetCore.Mvc;
using WebApi.Repositories.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatTestController(IChatApiClient chatApiClient): ControllerBase
    {
        [HttpPost("test")]
        public async Task<IActionResult> Test([FromBody] ChatTestRequest request)
        {
            var answer = await
                chatApiClient.SendMessageAsync(request.Message);
            return Ok(new { answer });
        }
    }
    public record ChatTestRequest(string Message);
}
