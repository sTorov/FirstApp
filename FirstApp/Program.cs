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

        //сортировка сначала по возрасту, потом - по имени
        var sortedStuds = from s in students
                          orderby s.Age, s.Name
                          select s;

        foreach(var student in sortedStuds)
            Console.WriteLine(student.Name + ", " + student.Age);
        Console.WriteLine();

        //или
        var sortedStuds2 = students
            .OrderBy(s => s.Age)
            .ThenBy(s => s.Name);

        foreach (var student in sortedStuds2)
            Console.WriteLine(student.Name + ", " + student.Age);
        Console.WriteLine();




        //сортировка сначала по имени, потом - по возрасту (убывание)
        var sortedStudsDesc = from s in students
                              orderby s.Name descending, s.Age descending
                              select s;

        foreach (var student in sortedStudsDesc)
            Console.WriteLine(student.Name + ", " + student.Age);
        Console.WriteLine();

        //или
        var sortedStuds2Desc = students
            .OrderByDescending(s => s.Name)
            .ThenByDescending(s => s.Age);

        foreach (var student in sortedStuds2Desc)
            Console.WriteLine(student.Name + ", " + student.Age);
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public IEnumerable<string> Languages { get; set; }
}