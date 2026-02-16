using Telegram.Bot;
using Telegram.Bot.Types;

namespace Practice23.Commands;

public class HelpCommand: ICommand
{
    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var chatId = update.Message!.Chat.Id;
        string text = "Доступные команды:\n" +
            "/start - приветствие\n" +
            "/help - помощь\n";

        await botClient.SendTextMessageAsync(chatId, text, cancellationToken: ct);
    }
}