using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        int[] numbers = { 1, 2, 3, 4, 5 };
        
        int result = numbers.Aggregate((x, y) => x - y);
        //вычислит 1 - 2 - 3 - 4 - 5 = -13
        Console.WriteLine(result);

        int sum = numbers.Aggregate((x, y) => x + y);
        //вычислит 1 + 2 + 3 + 4 + 5 = 15
        Console.WriteLine(sum);

    }    
}
