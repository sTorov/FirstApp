using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var numsList = new List<int[]>()
        {
           new[] {2, 3, 7, 1},
           new[] {45, 17, 88, 0},
           new[] {23, 32, 44, -6},
        };

        var sortedNumber = from numbers in numsList
                           from num in numbers
                           orderby num
                           select num;

        foreach(var num in sortedNumber)
            Console.WriteLine(num);
        Console.WriteLine();

        //Решение
        var numbers2 = numsList
            .SelectMany(s => s)
            .OrderBy(s => s);

        foreach(var num in numbers2)
            Console.WriteLine(num);
    }
}
