using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Configuration;
using TelegramBot.Servises;

namespace TelegramBot.Controllers
{
    class VoiceMessageController
    {
        private readonly AppSettings _appSettings;
        private readonly ITelegramBotClient _telegramClient;
        private readonly IFileHandler _audioFileHandler;

        public VoiceMessageController(ITelegramBotClient telegramClient, AppSettings appSettings, IFileHandler audioFileHandler)
        {
            _appSettings = appSettings;
            _telegramClient = telegramClient;
            _audioFileHandler = audioFileHandler;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            var fileId = message.Voice?.FileId;
            if(fileId == null)
                return;

            await _audioFileHandler.Download(fileId, ct);

            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Голосовое сообщение загружено", cancellationToken: ct);
        }
    }

}