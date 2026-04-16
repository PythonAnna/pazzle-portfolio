using Serilog;
using Telegram.Bot;
using WebApi.Commands;
using WebApi.Repositories.Implementations;
using WebApi.Repositories.Interfaces;
using WebApi.Settings;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/app-.log", rollingInterval: RollingInterval.Day)
                .CreateBootstrapLogger();

            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog();

            builder.Services.AddControllers().AddNewtonsoftJson();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<ChatApiSettings>(
                builder.Configuration.GetSection("ChatApi"));

            builder.Services.Configure<TelegramSettings>(
                builder.Configuration.GetSection("Telegram"));

            builder.Services.AddSingleton<ITelegramBotClient>(sp =>
            {
                var token = builder.Configuration["Telegram:BotToken"];
                return new TelegramBotClient(token!);
            });
            builder.Services.AddLogging();
            builder.Services.AddSingleton<IBotCommand, StartCommand>();
            builder.Services.AddSingleton<IBotCommand, HelpCommand>();
            builder.Services.AddSingleton<TelegramUpdateProcessor>();
            builder.Services.AddHttpClient<IChatApiClient, HttpChatApiClient>();
            builder.Services.AddSingleton<IChatModelRepository, ChatModelRepository>();
            builder.Services.AddSingleton<IBotCommand, StatsCommand>();
            builder.Services.AddSingleton<IBotCommand, ClearCommand>();
            builder.Services.AddSingleton<IBotCommand, UndoCommand>();
            builder.Services.AddSingleton<IBotCommand, SummarizeCommand>();

            var app = builder.Build();

            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}