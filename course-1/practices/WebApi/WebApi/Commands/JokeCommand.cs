using Telegram.Bot;
using WebApi.Dtos;
using WebApi.Repositories.Interfaces;
using WebApi.Repositories.Models;

namespace WebApi.Commands
{
    public class JokeCommand: IBotCommand
    {
        private readonly ILogger<JokeCommand> _logger;
        private readonly IChatModelRepository _chatModelRepository;
        private readonly IChatApiClient _chatApiClient;

        public JokeCommand(
            ILogger<JokeCommand> logger,
            IChatModelRepository chatModelRepository,
            IChatApiClient chatApiClient)
        {
            _logger = logger;
            _chatModelRepository = chatModelRepository;
            _chatApiClient = chatApiClient;
        }

        public string Trigger => "/joke";

        public async Task ExecuteAsync(TelegramUpdate update,
            ITelegramBotClient bot, long chatId)
        {
            _logger.LogInformation("Команда /joke выполнена для чата {ChatId}", chatId);

            var history = await
                _chatModelRepository.GetHistoryAsync(chatId);

            var jokePrompt = "Придумай смешную шутку, которой еще не было в диалоге.";

            var jokeHistory = history.ToList();
            jokeHistory.Add(new OpenApiResponse.Message
            {
                Role = "user",
                Content = jokePrompt
            });

            try
            {
                var response = await
                    _chatApiClient.SendMessageAsync(jokePrompt, jokeHistory);

                await bot.SendTextMessageAsync(chatId, response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании шутки для чата {ChatId}", chatId);
                await bot.SendTextMessageAsync(chatId, "Не смог придумать шутку :(");
            }
        }
    }
}
