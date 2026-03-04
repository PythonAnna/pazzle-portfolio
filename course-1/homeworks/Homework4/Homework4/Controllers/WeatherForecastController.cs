using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Tracing;

namespace Homework4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController: ControllerBase
    {
        private static List<string> words = new List<string>() { "Apple", "Car", "Hi" };

        [HttpGet]
        public List<string> GetAllWords()
        {
            return words;
        }
        [HttpPost]
        public IActionResult AddWord(string word)
        {
            words.Add($"{word}");
            return Ok(words);
        }
        [HttpDelete]
        public IActionResult DeleteWord(int index)
        {
            words.RemoveAt(index);
            return Ok(words);
        }
    }
}