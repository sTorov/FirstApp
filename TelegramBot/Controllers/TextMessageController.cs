﻿using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot.Controllers
{
    class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            switch (message.Text)
            {
                case "/start":
                    var buttons = new List<InlineKeyboardButton[]>();
                    buttons.Add(new[] 
                    {
                        InlineKeyboardButton.WithCallbackData($"Русский", $"ru"),
                        InlineKeyboardButton.WithCallbackData($"English", $"en"),
                        InlineKeyboardButton.WithCallbackData($"Français", $"fr"),
                        InlineKeyboardButton.WithCallbackData($"日本語", $"ja"),
                    });
                    await _telegramClient.SendTextMessageAsync
                        (
                            message.Chat.Id, 
                            $"<b> Наш бот превращает аудио в текст.</b>{Environment.NewLine}" +
                            $"{Environment.NewLine}Можно записать сообщение и переслать другу, если лень печатать.{Environment.NewLine}",
                            cancellationToken: ct,
                            parseMode: ParseMode.Html,
                            replyMarkup: new InlineKeyboardMarkup(buttons)
                        );
                    break;
                default:
                    Console.WriteLine($"Контроллер {GetType().Name} получил сообщение {message.Text}");
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Отправте аудио для превращения в текст", cancellationToken: ct);
                    break;
            }
        }
    }
}
