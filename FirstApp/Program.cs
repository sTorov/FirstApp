using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        int[] number = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        var evenNums = from i in number
                       where i % 2 == 0 && i > 10
                       select i;

        foreach(int i in evenNums)
            Console.WriteLine(i);
        Console.WriteLine();

        var evens = number.Where(i => i % 2 == 0 && i > 10);

        foreach(var i in evens)
            Console.WriteLine(i);
    }
}
