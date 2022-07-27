using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;

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
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient("5360370613:AAH-GlwbOI6REN-Yia-Sqqksrxvafl0BA3A"));
            services.AddHostedService<Bot>();
        }
    }
}
