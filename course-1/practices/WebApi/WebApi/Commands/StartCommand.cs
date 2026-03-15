using Telegram.Bot;
using WebApi.Dtos;

namespace WebApi.Commands
{
    public class StartCommand: IBotCommand
    {
        public string Trigger => "/start";
        public void ExecuteAsync(TelegramUpdate update, ITelegramBotClient bot, long chatId)
        {
            bot.SendTextMessageAsync(chatId, "Привет! Я OpenAI-бот. Отправь сообщение -- я передам его сторонней модели и верну ответ.\n/help для списка команд.");
        }
    }
}
