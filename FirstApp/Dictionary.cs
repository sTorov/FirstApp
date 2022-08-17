namespace FirstApp
{
    class Dictionary
    {
        public static void DictionaryTest()
        {
            Dictionary<string, Contact> bookPhone = new Dictionary<string, Contact>()
            {
                ["Дмитрий"] = new Contact(123123123, "dima@com.ru"),
                ["Иван"] = new Contact(456456456, "ivan@ivan.ru")
            };

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
            bookPhone.TryAdd("Василий", new Contact(111222333, "vasya@gmail.com"));

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
            if (bookPhone.TryGetValue("Василий", out Contact value))
                value.PhoneNumber = 000111000111;

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
        }
    }
}


