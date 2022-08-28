using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var simpleNumbers = new[] { 3, 5, 7 };

        //Вернёт 15
        Console.WriteLine(simpleNumbers.Sum());

        //Сложный тип данных, сложение свойств

        // Список студентов
        var students = new List<Student>
        {
            new Student {Name="Андрей", Age=23 },
            new Student {Name="Сергей", Age=27 },
            new Student {Name="Дмитрий", Age=29 }
        };

        //сумма возрастов всех студентов
        var totalAge = students.Sum(s => s.Age);

        //вернёт 79
        Console.WriteLine(totalAge);
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }        
    }
}
