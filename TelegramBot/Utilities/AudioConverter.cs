using TelegramBot.Extensions;
using FFMpegCore;

namespace TelegramBot.Utilities
{
    static public class AudioConverter
    {
        public static void TryConvert(string inputFile, string outputFile)
        {
            //Задаём путь, где лежит вспомогательная программа
            GlobalFFOptions.Configure(options => options.BinaryFolder = Path.Combine(DirectoryExtensions.GetSolutionRoot(), "ffmpeg-win64", "bin"));

            //Вызываем Ffmpeg, передав требуемые аргументы
            FFMpegArguments
                .FromFileInput(inputFile)
                .OutputToFile(outputFile, true, options => options.WithFastStart())
                .ProcessSynchronously();
        }
    }
}
