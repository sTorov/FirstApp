using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        //  создаём пустой список с типом данных Contact
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

        while(true)
        {
            char ch = Console.ReadKey(true).KeyChar;
            Console.Clear();

            if(!char.IsDigit(ch))
            {
                Console.WriteLine("Введите число!");
                continue;
            }

            IEnumerable<Contact> page = null;
            int number = int.Parse(ch.ToString());

            if (number > 0 && number < 4)
            {
                page = phoneBook.Skip((number - 1) * 2).Take(2);

                foreach(var contact in page)
                    Console.WriteLine(contact);
            }
            if(page == null)
                Console.WriteLine($"Страницы {ch} не существует!");
        }
    }
}
public class Contact // модель класса
{
    public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }

    public override string ToString()
    {
        return $"{Name, -13}{LastName, -13}{"Телефон:" + PhoneNumber, 23}{"Email:" + Email, 30}";
    }
}