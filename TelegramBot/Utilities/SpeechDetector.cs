using System.Text;
using Newtonsoft.Json.Linq;
using TelegramBot.Extensions;
using Vosk;

namespace TelegramBot.Utilities
{
    static public class SpeechDetector
    {
        public static string DetectSpeech(string audioPath, float inputBitrate, string languageCode)
        {
            Vosk.Vosk.SetLogLevel(-1);
            var modelPath = Path.Combine(DirectoryExtensions.GetSolutionRoot(), "Speech-models", $"vosk-model-small-{languageCode.ToLower()}");
            Model model = new(modelPath);
            return GetWords(model, audioPath, inputBitrate);
        }

        /// <summary>
        /// Основной метод для распознавания слов
        /// </summary>
        /// <param name="model"></param>
        /// <param name="audioPath"></param>
        /// <param name="inputBitrate"></param>
        /// <returns></returns>
        private static string GetWords(Model model, string audioPath, float inputBitrate)
        {
            //В конструктор для распознования передаём битрейт, а также используемую языковую модель
            VoskRecognizer rec = new(model, inputBitrate);
            rec.SetMaxAlternatives(0);
            rec.SetWords(true);

            StringBuilder textBuffer = new();

            using (Stream source = File.OpenRead(audioPath))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    //Распознание отдельных слов
                    if(rec.AcceptWaveform(buffer, bytesRead))
                    {
                        var sentenceJson = rec.Result();
                        //Сохраняем текстовый вывод в JSON-объект и извлекаем данные
                        JObject sentenceObj = JObject.Parse(sentenceJson);
                        string sentence = (string)sentenceObj["text"];
                        textBuffer.Append(StringExtension.UppercaseFirst(sentence) + ". ");
                    }
                }
            }

            //Распознание предложений
            var finalSentence = rec.FinalResult();
            //Сохраняем текстовый вывод в JSON-объект и извлекаем данные
            JObject finalSentenceObj = JObject.Parse(finalSentence);

            //Собираем итоговый текст
            textBuffer.Append((string)finalSentenceObj["text"]);
            //Возвращаем вид строки
            return textBuffer.ToString();
        }
    }
}
