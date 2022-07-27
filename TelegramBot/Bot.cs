namespace TelegramBot
{
    class Bot
    {
        /// <summary>
        /// Объект, отвечающий за отправку сообщений клиенту
        /// </summary>
        private IBotClient _telegarmClient;

        public Bot(IBotClient telegramClient)
        {
            _telegarmClient = telegramClient;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _telegarmClient.OnMessage += HandleMessage;
            _telegarmClient.OnMessage += HandleButtonClick;

            Console.WriteLine("Bot started");
        }

        /// <summary>
        /// Обработчик входящих текстовых сообщений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task HandleMessage(object sender, MessageEventArgs e)
        {
            //Бот получает входящее сообщение пользователя
            var messageText = e.Message.Text;

            //Бот отправляет ответ
            _telegarmClient.SendTextMessage(e.ChatId, "Ответ на сообщение пользователя");
        }

        /// <summary>
        /// Обработчик нажатий на кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task HandleButtonClick(object sender, MessageEventArgs e)
        {

        }
    }
}
