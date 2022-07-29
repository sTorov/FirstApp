using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBot.Servises;

namespace TelegramBot.Controllers
{
    class InlineKeyboardController
    {
        private readonly IStorage _memoryStorage;
        private readonly ITelegramBotClient _telegramClient;

        public InlineKeyboardController(ITelegramBotClient telegramClient, IStorage memoryStorage)
        {
            _telegramClient = telegramClient;
            _memoryStorage = memoryStorage;
        }

        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            if(callbackQuery?.Data == null)
                return;

            _memoryStorage.GetSession(callbackQuery.From.Id).LanguageCode = callbackQuery.Data;
            
            string languageText = callbackQuery.Data switch
            {
                "ru" => "Русский",
                "en" => "Английский",
                _ => String.Empty
            };
            
            Console.WriteLine($"Контроллер {GetType().Name} обнаружил нажатие на кнопку");
            await _telegramClient.SendTextMessageAsync
                (
                    callbackQuery.From.Id, 
                    $"<b>Язык аудио - {languageText}.{Environment.NewLine}</b>" +
                    $"{Environment.NewLine}Можно поменять в главном меню.",
                    cancellationToken: ct,
                    parseMode: ParseMode.Html
                );
        }
    }
}
