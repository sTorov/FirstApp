using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using TelegramBot.Controllers;
using TelegramBot.Servises;
using TelegramBot.Configuration;

namespace TelegramBot
{
    class Program
    {
         public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var host = new HostBuilder().ConfigureServices((hostContext, services) => ConfigureServices(services)).UseConsoleLifetime().Build();

            Console.WriteLine("Сервер запущен");

            await host.RunAsync();
            Console.WriteLine("Сервер остановлен");
        }

        static void ConfigureServices(IServiceCollection services)
        {
            AppSettings appSettings = BuildAppSettings();
            services.AddSingleton(BuildAppSettings());
            
            services.AddTransient<DefaultMessageController>();
            services.AddTransient<VoiceMessageController>();
            services.AddTransient<TextMessageController>();
            services.AddTransient<InlineKeyboardController>();
            services.AddSingleton<IFileHandler, AudioFileHandler>();

            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(appSettings.BotToken));
            services.AddSingleton<IStorage, MemoryStorage>();
            
            services.AddHostedService<Bot>();
        }

        static AppSettings BuildAppSettings()
        {
            return new AppSettings
            {
                DownloadFolder = @"C:\Users\1357680\Downloads",
                BotToken = "5360370613:AAH-GlwbOI6REN-Yia-Sqqksrxvafl0BA3A",
                AudioFileName = "audio",
                InputAudioFormat = "ogg",
                OutputAudioFormat = "wav",
                InputAudioBitrate = 48000F
            };
        }
    }
}
