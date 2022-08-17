using System.Collections;
using System.Text;

class Program
{
    static void Main()
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
        if (bookPhone.TryGetValue("Василий", out Contact? value))           /////////////////
            value.PhoneNumber = 000111000111;

        foreach (var contact in bookPhone)
            Console.WriteLine(contact.Key + ": " + contact.Value);

        Console.WriteLine();
    }
}
public class Contact // модель класса
{
    public Contact(long phoneNumber, string email) // метод-конструктор
    {
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public long PhoneNumber { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return "Телефон: " + PhoneNumber + " E-mail: " + Email;
    }
}