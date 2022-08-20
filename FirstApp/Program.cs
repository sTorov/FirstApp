using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        var names = people.Where(p => p.StartsWith("А")).OrderBy(p => p);

        foreach(string name in names)
            Console.WriteLine(name);
    }
}
