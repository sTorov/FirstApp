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

        var strs = from obj in objects
                   where obj is string //obj.GetType() == typeof(string)
                   orderby obj
                   select obj;
                   
        foreach(var s in strs)
            Console.WriteLine(s);
    }
}
