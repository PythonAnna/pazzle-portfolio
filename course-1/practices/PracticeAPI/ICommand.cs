using Telegram.Bot;
using Telegram.Bot.Types;

namespace Practice23.Commands;

public interface ICommand
{
    Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct);
}