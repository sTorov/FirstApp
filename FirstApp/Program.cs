using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        //Список студентов
        List<Student> students = new List<Student>
        {
            new Student { Name = "Андрей" , Age =23, Languages = new List<string>{ "английский", "немнцкий" } },
            new Student { Name = "Сергей" , Age =27, Languages = new List<string>{ "английский", "французский" } },
            new Student { Name = "Дмитрий" , Age =29, Languages = new List<string>{ "английский", "испанский" } },
            new Student { Name = "Василий" , Age =24, Languages = new List<string>{ "испанский", "немнцкий" } },
        };

        //Список курсов
        var coarses = new List<Coarse>
        {
            new Coarse { Name = "Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
            new Coarse { Name = "Язык SQL и реляционные бфзы данных", StartDate = new DateTime(2020, 12, 15)}
        };

        var studentsWithCoarses = from s in students
                                  where s.Languages.Contains("английский") && s.Age < 29
                                  let yearBirth = DateTime.Now.Year - s.Age
                                  from c in coarses
                                  where c.Name == "Язык программирования C#" // c.Name.Contains("C#")
                                  select new
                                  {
                                      Name = s.Name,
                                      YearOfBirth = yearBirth,
                                      CoarseName = c.Name
                                  };

        foreach(var item in studentsWithCoarses)
            Console.WriteLine(item.Name + ", " + item.YearOfBirth + "\t" + item.CoarseName);
    }   
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}

public class Coarse
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}
