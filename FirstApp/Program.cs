using System.Runtime.InteropServices;
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

        //получим тех, кто младше 25 лет
        var youngStudentsAmount = (from student in students
                             where student.Age < 25
                             select student).Count();

        //выведем 1
        Console.WriteLine(youngStudentsAmount);

        //более короткий вариант (получим теч, кто младшее 25 лет)
        var youngStudent = students.Count(s => s.Age < 25);

        //выведем 2
        Console.WriteLine(youngStudent);

    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}
