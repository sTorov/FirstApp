namespace FirstApp
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, Contact> bookPhone = new Dictionary<string, Contact>()
        {
            {"Дмитрий", new Contact(123123123, "dima@com.ru") },
            {"Иван", new Contact(456456456, "ivan@ivan.ru") }
        };

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
            bookPhone.Add("Василий", new Contact(111222333, "vasya@gmail.com"));

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
            if (bookPhone.ContainsKey("Василий"))
                bookPhone["Василий"] = new Contact(000111000111, bookPhone["Василий"].Email);

            foreach (var contact in bookPhone)
                Console.WriteLine(contact.Key + ": " + contact.Value);

            Console.WriteLine();
        }
    }
}


