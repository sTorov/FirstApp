using Telegram.Bot;
using TelegramBot.Configuration;

namespace TelegramBot.Servises
{
    public class AudioFileHandler : IFileHandler
    {
        private readonly AppSettings _appSettings;
        private readonly ITelegramBotClient _telegramClient;
        public AudioFileHandler(AppSettings appSettings, ITelegramBotClient telegramClient)
        {
            _appSettings = appSettings;
            _telegramClient = telegramClient;
        }

        public async Task Download(string fileId, CancellationToken ct)
        {
            //Генерируем полный путь файла из конфигураций
            string inputAudioFilePath = Path.Combine(_appSettings.DownloadFolder, $"{_appSettings.AudioFileName}.{_appSettings.InputAudioFormat}");

            using(FileStream destinationStream = File.Create(inputAudioFilePath))
            {
                //Загружаем информацию о файле
                var file = await _telegramClient.GetFileAsync(fileId, ct);

                if (file.FilePath == null)
                    return;

                //Скачиваем файл
                await _telegramClient.DownloadFileAsync(file.FilePath, destinationStream, ct);
            }
        }

        public string Process(string param)
        {
            throw new NotImplementedException();
        }
    }
}
