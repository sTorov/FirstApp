using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        var phoneBook = new List<Contact>();

        phoneBook.Add(new Contact("Dima", "dima@gmail.com", 78991234567));
        phoneBook.Add(new Contact("Ivan", "ivan@gmail.com", 78911987654));

        Console.WriteLine(phoneBook[0].Equals(phoneBook[0]));
        Console.WriteLine(phoneBook[0].Equals(phoneBook[1]));
        Console.WriteLine(phoneBook[0].Equals(new object()));

        Console.WriteLine(AddUnique(new Contact("Dima", "dima@gmail.com", 78991234567), phoneBook));
        Console.WriteLine(AddUnique(new Contact("Ivan", "ivan@gmail.com", 78911987654), phoneBook));
        Console.WriteLine(AddUnique(new Contact("Anton", "anton@gmail.com", 78991234567), phoneBook));
        Console.WriteLine(AddUnique(new Contact("Dima", "dima@gmail.com", 71111111111), phoneBook));

    }

    static bool AddUnique(Contact contact, List<Contact> phoneBook)
    {
        if (phoneBook.Contains(contact))
            return false;

        phoneBook.Add(contact);
        phoneBook.Sort();
        foreach(var item in phoneBook)
            Console.WriteLine(item);

        return true;
    }
}

class Contact : IComparable<Contact>
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

    public override bool Equals(object? obj)
    {
        if(obj is Contact contact)
        {
            if(Name == contact.Name && Email == contact.Email && PhoneNumber == contact.PhoneNumber)
                return true;
            return false;
        }
        return false;
    }

    public override string ToString()
    {
        return "Имя: " + Name + " E-mail: " + Email + " Телефон: " + PhoneNumber;
    }

    public int CompareTo(Contact? obj)
    {
        return Name.CompareTo(obj?.Name);
    }
}