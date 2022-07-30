using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Servises;

namespace TelegramBot.Controllers
{
    class VoiceMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IFileHandler _audioFileHandler;
        private readonly IStorage _memoryStorage;

        public VoiceMessageController(ITelegramBotClient telegramClient, IFileHandler audioFileHandler, IStorage memoryStorage)
        {
            _telegramClient = telegramClient;
            _audioFileHandler = audioFileHandler;
            _memoryStorage = memoryStorage;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            var fileId = message.Voice?.FileId;
            if(fileId == null)
                return;

            await _audioFileHandler.Download(fileId, ct);

            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Голосовое сообщение загружено", cancellationToken: ct);

            var userLanguageCode = _memoryStorage.GetSession(message.Chat.Id).LanguageCode;
            _audioFileHandler.Process(userLanguageCode);

            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Голосовое сообщение успешно конвертировано в формат .WAV", cancellationToken: ct);
        }
    }

}