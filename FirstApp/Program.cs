using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;


        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

        var str = from s in words
                  orderby s.Length
                  select new 
                  { 
                      Word = s,
                      Length = s.Length
                  };

        foreach (var item in str)
            Console.WriteLine(item.Word + " " + item.Length);
        Console.WriteLine();

        //или
        var str2 = words.Select(s => 
        new 
        { 
            Word = s, 
            Length = s.Length 
        })
        .OrderBy(s => s.Length);

        foreach (var item in str2)
            Console.WriteLine(item.Word + " " + item.Length);
    }   
}
