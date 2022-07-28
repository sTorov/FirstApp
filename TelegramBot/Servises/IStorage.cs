using TelegramBot.Models;

namespace TelegramBot.Servises
{
    interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по индентификатору
        /// </summary>
        /// <param name="chatId"></param>
        /// <returns></returns>
        Session GetSession(long chatId);
    }
}
