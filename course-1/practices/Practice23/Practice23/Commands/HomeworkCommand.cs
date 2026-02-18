using Practice23.Repositories;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Practice23.Commands;

public class HomeworkCommand : ICommand
{
    protected readonly IHomeworkRepository _homeworkRepository;

    public HomeworkCommand(IHomeworkRepository homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }


    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var chatId = update.Message!.Chat.Id;
        var text = update.Message!.Text ?? string.Empty;

        var parts = text.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2)
        {
            await botClient.SendTextMessageAsync(
                chatId,
                "Использование: /homework [группа]\nНапример: /homework ПР-2-А",
                cancellationToken: ct);
            return;
        }

        var groupName = parts[1].Trim();

        var homework = _homeworkRepository.Load();
        var group = homework.Groups
            .FirstOrDefault(g => string.Equals(g.Group, groupName, StringComparison.OrdinalIgnoreCase));

        if (group == null)
        {
            await botClient.SendTextMessageAsync(
                chatId,
                $"Для группы {groupName} нет домашнего задания.",
                cancellationToken: ct);
            return;
        }

        var lines = new List<string> { $"Полное расписание для {groupName}:" };

        foreach (var day in group.Days)
        {
            lines.Add($"\n{day.Day}:");
            if (day.Homework == null || day.Homework.Count == 0)
            {
                lines.Add("  нет уроков");
            }
            else
            {
                lines.AddRange(
                    day.Homework.Select(
                        (l, i) => $"  {i + 1}. {l.Work} -- {l.Subject} {(string.IsNullOrEmpty(l.Teacher) ? "" : "(" + l.Teacher + ")")}"
                    )
                );
            }
        }

        await botClient.SendTextMessageAsync(chatId, string.Join('\n', lines), cancellationToken: ct);
    }
}