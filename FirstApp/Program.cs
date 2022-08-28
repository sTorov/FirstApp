using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var nums = new[] { 1, 7, 45, 23 };

        int greatest = nums.Max();//вернёт 45
        int smallest = nums.Min();//вернёт 1
        double average = nums.Average();//вернёт 19

        Console.WriteLine($"{greatest}, {smallest}, {average}");

        //Сложный тип данных

        // Список студентов
        List<Student> students = new List<Student>
        {
            new Student { Name = "Алёна" , Age =23, Languages = new List<string>{ "английский", "неменцкий" } },
            new Student { Name = "Яков" , Age =23, Languages = new List<string>{ "английский", "неменцкий" } },
            new Student { Name = "Андрей" , Age =23, Languages = new List<string>{ "английский", "неменцкий" } },
            new Student { Name = "Сергей" , Age =27, Languages = new List<string>{ "английский", "французский" } },
            new Student { Name = "Дмитрий" , Age =29, Languages = new List<string>{ "английский", "испанский" } },
            new Student { Name = "Василий" , Age =24, Languages = new List<string>{ "испанский", "неменцкий" } },
        };

        //найдём возраст самого старого студента (29)
        var oldest = students.Max(s => s.Age);

        //самого молодого (23)
        var youngest = students.Min(s => s.Age);

        // и средний возраст (26,3)
        var averageAge = students.Average(s => s.Age);

        Console.WriteLine($"\n{oldest}\n{youngest}\n{averageAge:0.0}");

        //средний возраст студентов, владующих английским языком
        var avrAgeEngLang = students
            .Where(s => s.Languages.Contains("английский"))
            .Average(s => s.Age);

        Console.WriteLine(Environment.NewLine + avrAgeEngLang);
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }

        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
