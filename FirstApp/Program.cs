using System;

class FirstApp
{
	enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    static void Main(string[] args)
    {
        var grouth = 181;
        var myshoe = 41.5;

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        var age = checked( (byte) int.Parse(Console.ReadLine()));

        Console.WriteLine();

        Console.WriteLine($"Your name is {name} and age is {age}");
        Console.WriteLine($"What is my grouth? {grouth} sm");
        Console.WriteLine($"What is my shoe size? {myshoe}\n");

        Console.Write("What is your favorite days of week? ");
        var day = (DaysOfWeek) byte.Parse(Console.ReadLine());
        Console.WriteLine($"Your favorite day is {day}");

        Console.ReadKey();
	}
}