using TelegramBot.Models;
using System.Collections.Concurrent;

namespace TelegramBot.Servises
{
    class MemoryStorage : IStorage
    {
        /// <summary>
        /// Хранилище сессий
        /// </summary>
        private readonly ConcurrentDictionary<long, Session> _session;

        public MemoryStorage()
        {
            _session = new ConcurrentDictionary<long, Session>();
        }

        public Session GetSession(long chatId)
        {
            if(_session.ContainsKey(chatId))
                return _session[chatId];

            var newSession = new Session { LanguageCode = "ru" };
            _session.TryAdd(chatId, newSession);
            return newSession;
        }
    }
}
