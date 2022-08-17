using System.Diagnostics;

namespace FirstApp
{
    class SortedDictionary
    {
        public static void SortedDictionaryTest()
        {
            SortedDictionary<string, Contact> bookPhone = new SortedDictionary<string, Contact>()
            {
                ["Дмитрий"] = new Contact(123123123, "dima@com.ru"),
                ["Иван"] = new Contact(456456456, "ivan@ivan.ru")
            };

            //foreach (var contact in bookPhone)
            //    Console.WriteLine(contact.Key + ": " + contact.Value);

            //Console.WriteLine();

            Stopwatch watch = Stopwatch.StartNew();

            bookPhone.TryAdd("Василий", new Contact(111222333, "vasya@gmail.com"));

            Console.WriteLine(watch.Elapsed.TotalMilliseconds + "\n");

            //foreach (var contact in bookPhone)
            //    Console.WriteLine(contact.Key + ": " + contact.Value);

            //Console.WriteLine();
            //if (bookPhone.TryGetValue("Василий", out Contact value))
            //    value.PhoneNumber = 000111000111;

            //foreach (var contact in bookPhone)
            //    Console.WriteLine(contact.Key + ": " + contact.Value);

            //Console.WriteLine();
        }
    }
}
