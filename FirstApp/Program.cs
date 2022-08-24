using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Список студентов
        var students = new List<Student>
        {
           new Student {Name="Алёна", Age=23, Languages = new List<string> {"английский", "немецкий" }},
           new Student {Name="Яков", Age=23, Languages = new List<string> {"английский", "немецкий" }},
           new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
           new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
           new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
           new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
        };

        //сортировка по возрастанию
        var sortStud = from s in students 
                       orderby s.Age 
                       select s;

        //или
        var sortAsc = students.OrderBy(s => s.Age);

        foreach(var student in sortStud)
            Console.WriteLine(student.Name + ", " + student.Age);
        Console.WriteLine();

        //сортировка по убыванию
        var sortStudDesending = from s in students
                       orderby s.Age descending
                       select s;

        //или
        var sortDesc = students.OrderByDescending(s => s.Age);

        foreach (var student in sortStudDesending)
            Console.WriteLine(student.Name + ", " + student.Age);
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public IEnumerable<string> Languages { get; set; }
}