using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        var objects = new List<object>()
        {
           1,
           "Сергей ",
           "Андрей ",
           300,
        };

        foreach(var str in objects.Where(o => o is string).OrderBy(o => o))
            Console.WriteLine(str);
    }
}
