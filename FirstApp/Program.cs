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
            new Student{Name = "Андрей", Age = 23, Languages = new List<string>{ "английский", "немецкий" }},
            new Student{Name = "Сергей", Age = 27, Languages = new List<string>{ "английский", "французский" }},
            new Student{Name = "Дмитрий", Age = 29, Languages = new List<string>{ "английский", "испанский" }},
            new Student{Name = "Василий", Age = 24, Languages = new List<string>{ "испанский", "немецкий" }},
        };

        //Создадим запрос
        var selectedStudents = students.SelectMany(
            //коллекция, которую нужно преобразовать
            s => s.Languages,
            //функция преобразования, применяющаяся к каждому элементу коллекции
            (s, l) => new { Student = s, Lang = l })
            //дополнительные условия
            .Where(s => s.Lang == "английский" && s.Student.Age < 28)
            .Select(s => s.Student);

        //Выведем результат
        foreach(var student in selectedStudents)
            Console.WriteLine($"{student.Name} - {student.Age}");
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
    }
}
