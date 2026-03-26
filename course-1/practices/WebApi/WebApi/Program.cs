using Telegram.Bot;
using WebApi.Commands;
using WebApi.Repositories.Implementations;
using WebApi.Repositories.Interfaces;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllers().AddNewtonsoftJson();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var telegramToken = "7942247996:AAHPB9PD-u-yDbHyKmyhhu4FNpHqCkEzFyI";
            builder.Services.AddSingleton<ITelegramBotClient>(sp => new TelegramBotClient(telegramToken));
            builder.Services.AddSingleton<IBotCommand, StartCommand>();
            builder.Services.AddSingleton<IBotCommand, HelpCommand>();
            builder.Services.AddSingleton<TelegramUpdateProcessor>();
            builder.Services.AddHttpClient<IChatApiClient, HttpChatApiClient>();

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