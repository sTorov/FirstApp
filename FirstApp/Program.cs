using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var contacts = new List<Contact>()
        {
           new Contact() { Name = "Андрей", Phone = 79994500508 },
           new Contact() { Name = "Сергей", Phone = 799990455 },
           new Contact() { Name = "Иван", Phone = 79999675334 },
           new Contact() { Name = "Игорь", Phone = 8884994 },
           new Contact() { Name = "Анна", Phone = 665565656 },
           new Contact() { Name = "Василий", Phone = 3434 }
        };

        var incorrectNumber = contacts.Count(c => !c.Phone.ToString().StartsWith('7') || c.Phone.ToString().Length != 11);

        Console.WriteLine(incorrectNumber);

        //Решение
        var count = (from contact in contacts//пробегаемся по контактам 
                     let phoneString = contact.Phone.ToString()//сохраняем в промежуточную переменную строку номера телефона
                     where phoneString.Length != 11 || !phoneString.StartsWith('7')//выполняем проверку по условию
                     select contact)//добавляем объект в выборку 
                     .Count();//считаем количество

        Console.WriteLine(count);
    }

    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }        
    }
}
