using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        var phoneBook = new List<Contact>();

        phoneBook.Add(new Contact("Dima", "dima@gmail.com", 78991234567));
        phoneBook.Add(new Contact("Ivan", "ivan@gmail.com", 78911987654));

        foreach (Contact contact in phoneBook)
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