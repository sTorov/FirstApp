using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        var phoneBook = new List<Contact>();

        phoneBook.Add(new Contact("Dima", "dima@gmail.com", 78991234567));
        phoneBook.Add(new Contact("Ivan", "ivan@gmail.com", 78911987654));

        AddUnique(new Contact("Dima", "dima@gmail.com", 78991234567), phoneBook);
        AddUnique(new Contact("Ivan", "ivan@gmail.com", 78911987654), phoneBook);
        AddUnique(new Contact("Anton", "anton@gmail.com", 78991234567), phoneBook);
        AddUnique(new Contact("Dima", "dima@gmail.com", 71111111111), phoneBook);

    }

    private static void AddUnique(Contact newContact, List<Contact> phoneBook)
    {
        bool alreadyExists = false;

        // пробегаемся по списку и смотрим, есть ли уже с таким именем
        foreach (var contact in phoneBook)
        {
            if (contact.Name == newContact.Name)
            {
                //  если вдруг находим  -  выставляем флаг и прерываем цикл
                alreadyExists = true;
                break;
            }
        }

        if (!alreadyExists)
            phoneBook.Add(newContact);

        //  сортируем список по имени
        phoneBook.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

        foreach (var contact in phoneBook)
            Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
    }
}

class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
    public long PhoneNumber { get; set; }

    public Contact(string name, string email, long phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}