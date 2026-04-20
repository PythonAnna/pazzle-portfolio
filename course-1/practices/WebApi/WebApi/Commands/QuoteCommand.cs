using Telegram.Bot;
using WebApi.Dtos;
using WebApi.Repositories.Interfaces;
using WebApi.Repositories.Models;

namespace WebApi.Commands
{
    public class QuoteCommand: IBotCommand
    {
        private readonly ILogger<QuoteCommand> _logger;
        private readonly IChatModelRepository _chatModelRepository;
        private readonly IChatApiClient _chatApiClient;

        public QuoteCommand(
            ILogger<QuoteCommand> logger,
            IChatModelRepository chatModelRepository,
            IChatApiClient chatApiClient)
        {
            _logger = logger;
            _chatModelRepository = chatModelRepository;
            _chatApiClient = chatApiClient;
        }

        public string Trigger => "/quote";

        public async Task ExecuteAsync(TelegramUpdate update,
            ITelegramBotClient bot, long chatId)
        {
            _logger.LogInformation("Команда /quote выполнена для чата {ChatId}", chatId);

            var history = await
                _chatModelRepository.GetHistoryAsync(chatId);

            var quotePrompt = "Вспомни известную цитату или придумай свою, которой еще не было в диалоге.";

            var quoteHistory = history.ToList();
            quoteHistory.Add(new OpenApiResponse.Message
            {
                Role = "user",
                Content = quotePrompt
            });

            try
            {
                var response = await
                    _chatApiClient.SendMessageAsync(quotePrompt, quoteHistory);

                await bot.SendTextMessageAsync(chatId, response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании цитаты для чата {ChatId}", chatId);
                await bot.SendTextMessageAsync(chatId, "Ошибка при создании цитаты. Попробуйте позже.");
            }
        }
    }
}
