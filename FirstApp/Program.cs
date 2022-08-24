using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        //Подготовим данные
        List<Student> students = new List<Student>
        {
            new Student { Name = "Андрей" , Age =23, Languages = new List<string>{ "английский", "немнцкий" } },
            new Student { Name = "Сергей" , Age =27, Languages = new List<string>{ "английский", "французский" } },
            new Student { Name = "Дмитрий" , Age =29, Languages = new List<string>{ "английский", "испанский" } },
            new Student { Name = "Василий" , Age =24, Languages = new List<string>{ "испанский", "немнцкий" } },
        };

        var fullNameStudents = from s in students
                               //временная переменная для генерации полного имени
                               let fullName = s.Name + " Иванов"
                               //проекция в новую сущность с использованием новой переменой
                               select new
                               {
                                   Name = fullName,
                                   Age = s.Age
                               };

        foreach(var item in fullNameStudents)
            Console.WriteLine(item.Name + ", " + item.Age);
    }   
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}

public class Application
{
    public string FirstName { get; set; }
    public int YearOfBirth { get; set; }
}
