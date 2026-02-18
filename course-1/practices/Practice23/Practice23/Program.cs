using Practice23.Commands;
using Practice23.Repositories;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

class Program
{
    private const string ScheduleJson = "schedule1.json";
    private const string HomeworkJson = "homework.json";
    public static async Task Main()
    {
        Console.WriteLine("Запуск бота...");

        var token = "7942247996:AAHPB9PD-u-yDbHyKmyhhu4FNpHqCkEzFyI";
        var botClient = new TelegramBotClient(token);

        var scheduleRepository = new JsonScheduleRepository(ScheduleJson);
        var homeworkRepository = new JsonHomeworkRepository(HomeworkJson);

        var dispatcher = new CommandDispatcher();
        dispatcher.Register("/start", new StartCommand());
        dispatcher.Register("/help", new HelpCommand());
        dispatcher.Register("/week", new WeekCommand(scheduleRepository));
        dispatcher.Register("/homework", new HomeworkCommand(homeworkRepository));

        using var cts = new CancellationTokenSource();
        var receiverOptions = new ReceiverOptions { AllowedUpdates = Array.Empty<UpdateType>() };


        botClient.StartReceiving(
           async (client, update, ct) => await dispatcher.DispatchAsync(update, client, ct),
           HandleErrorAsync,
           receiverOptions,
           cts.Token);


        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Бот запущен: @{me.Username}");
        Console.ReadLine();
        cts.Cancel();
    }


    static Task HandleErrorAsync(ITelegramBotClient bot, Exception ex, CancellationToken ct)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
        return Task.CompletedTask;
    }
}



