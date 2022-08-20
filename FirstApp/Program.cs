using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        List<string> names = new List<string>();

        foreach (var human in people)
            if (human.ToUpper().StartsWith("А"))
                names.Add(human);

        names.Sort();

        foreach(string name in names)
            Console.WriteLine(name);
    }
}
