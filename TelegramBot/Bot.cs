using Telegram.Bot;

namespace TelegramBot
{
    class Bot
    {
        private ITelegramBotClient _telegarmClient;

        public Bot(ITelegramBotClient telegramClient)
        {
            _telegarmClient = telegramClient;
        }
    }
}
