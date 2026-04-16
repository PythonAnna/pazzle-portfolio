using Telegram.Bot;
using WebApi.Dtos;
using WebApi.Repositories.Interfaces;

namespace WebApi.Commands
{
    public class UndoCommand: IBotCommand
    {
        private readonly ILogger<UndoCommand> _logger;
        private readonly IChatModelRepository _chatModelRepository;

        public UndoCommand(
            ILogger<UndoCommand> logger,
            IChatModelRepository chatModelRepository)
        {
            _logger = logger;
            _chatModelRepository = chatModelRepository;
        }

        public string Trigger => "/undo";

        public async Task ExecuteAsync(TelegramUpdate update,
            ITelegramBotClient bot, long chatId)
        {
            _logger.LogInformation("Комманда /undo выполнена для чата {ChatId}", chatId);

            var removedAssistent = await
                _chatModelRepository.RemoveLastMessageAsync(chatId);

            if(removedAssistent)
            {
                await
                    _chatModelRepository.RemoveLastMessageAsync(chatId);
                await bot.SendTextMessageAsync(chatId, "Последний обмен сообщениями удален.");
            }
            else
            {
                await bot.SendTextMessageAsync(chatId, "История пуста. Нечего удалять.");
            }
        }
    }
}
