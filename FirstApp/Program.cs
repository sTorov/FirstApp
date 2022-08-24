using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        IEnumerable<Contact> page = default;
        var contacts = new List<Contact>()
        {
           new Contact() { Name = "Андрей", Phone = 7999945005 },
           new Contact() { Name = "Сергей", Phone = 799990455 },
           new Contact() { Name = "Иван", Phone = 79999675 },
           new Contact() { Name = "Игорь", Phone = 8884994 },
           new Contact() { Name = "Анна", Phone = 665565656 },
           new Contact() { Name = "Василий", Phone = 3434 }
        };

        while(true)
        {
            char ch = Console.ReadKey(true).KeyChar;

            if(int.TryParse(ch.ToString(), out int result) && result > 0 && result < 4)
            {
                Console.Clear();
                page = contacts.Skip((result - 1) * 2).Take(2);

                foreach(var contact in page)
                    Console.WriteLine(contact.Name + " " + contact.Phone);
            }
        }
    }   
}

public class Contact
{
    public string Name { get; set; }
    public long Phone { get; set; }
}