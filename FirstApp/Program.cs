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

        var studentsApplication = from s in students
                    //создадим анонимный тип для представления анкеты 
                    select new    
                    {
                        FirstName = s.Name,
                        YearOfBirth = DateTime.Now.Year - s.Age
                    };

        //или
        var studentsApplicationClass = from s in students
                    //спроецируем в новую сущность анкеты
                    select new Application
                    {
                        FirstName = s.Name,
                        YearOfBirth = DateTime.Now.Year - s.Age
                    };

        //Выведем результат (результат будет одинаковый)
        foreach(var application in studentsApplication)
            Console.WriteLine($"{application.FirstName}, {application.YearOfBirth}");
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
