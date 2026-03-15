using Microsoft.AspNetCore.Mvc;
using WebApi.Commands;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly TelegramUpdateProcessor _processor;
        public UpdateController(TelegramUpdateProcessor processor)
        {
            _processor = processor;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TelegramUpdate update)
        {
            _processor.Handle(update);
            return Ok();
        }
    }
}
