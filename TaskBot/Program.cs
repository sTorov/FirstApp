using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;

namespace TaskBot
{
    class Program
    {
        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var host = new HostBuilder().ConfigureServices((hostContext, service) => Configure(service)).UseConsoleLifetime().Build();

            Console.WriteLine("Сервер запущен");

            await host.RunAsync();
            Console.WriteLine("Сервер остановлен");
        }

        static void Configure(IServiceCollection services)
        {
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient("5506694649:AAEthtzgiRpdrJCv1l9mBtGshzX6NhnQRtw"));
            services.AddHostedService<Bot>();
        }
    }
}