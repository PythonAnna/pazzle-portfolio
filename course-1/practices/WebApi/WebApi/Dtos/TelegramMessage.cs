using Telegram.Bot.Types;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos
{
    public class TelegramMessage
    {
        [Required]
        public int MessageId { get; set; }
        public Chat Chat { get; set; } = new Chat();
        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string? Text { get; set; }
        [Required]
        public int Date { get; set; }
    }
}

