using Telegram.Bot;
using Telegram.Bot.Types;

namespace Practice23.Commands;

public class HelpCommand : ICommand
{
    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var chatId = update.Message!.Chat.Id;
        string text = "Доступные команды:\n" +
            "/start - приветствие\n" +
            "/week ПР-2-А - расписание на неделю\n"+
            "/homework ПР-2-А - домашнее задание для группы ПР-2-А\n"+
            "/help - помощь\n";

        await botClient.SendTextMessageAsync(chatId, text, cancellationToken: ct);
    }
}