﻿using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Controllers
{
    class VoiceMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public VoiceMessageController(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено голосовое сообщение", cancellationToken: ct);
        }
    }

}