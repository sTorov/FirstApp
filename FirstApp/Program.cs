using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var simpleNumbers = new[] { 3, 3, 4 };

        Console.WriteLine(Average(simpleNumbers));
    }
    static double Average(int[] numbers)
    {
        return Math.Round((double)numbers.Sum() / numbers.Length, 5);
    }
}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }        
}
