using Telegram.Bot;
using WebApi.Dtos;

namespace WebApi.Commands
{
    public interface IBotCommand
    {
        string Trigger { get; }
        void ExecuteAsync(TelegramUpdate update, ITelegramBotClient bot, long chatId);
    }
}
