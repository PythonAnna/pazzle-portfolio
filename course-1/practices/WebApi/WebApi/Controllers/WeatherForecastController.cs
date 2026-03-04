using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController: ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok("Hello, World!");
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UpdateController update)
        {
            Console.WriteLine("Hello");
            return Ok();
        }
    }
}
