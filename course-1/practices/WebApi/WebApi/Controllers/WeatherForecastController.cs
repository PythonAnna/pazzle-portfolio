using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TelegramUpdate update)
        {
            Console.WriteLine(update?.Message?.Text);
            return Ok();
        }
    }
}
