﻿namespace TelegramBot.Configuration
{
    public class AppSettings
    {
        /// <summary>
        /// Токен Telegram API
        /// </summary>
        public string BotToken { get; set; }

        /// <summary>
        /// Папка загрузки файлов
        /// </summary>
        public string DownloadFolder { get; set; }
        /// <summary>
        /// Имя файла при загрузке
        /// </summary>
        public string AudioFileName { get; set; }
        /// <summary>
        /// Формат аудио при загрузке
        /// </summary>
        public string InputAudioFormat { get; set; }
        /// <summary>
        /// Формат конвертированого аудио файла
        /// </summary>
        public string OutputAudioFormat { get; set; }
        /// <summary>
        /// Битрейт аудио при загрузке
        /// </summary>
        public float InputAudioBitrate { get; set; } 
    }
}
