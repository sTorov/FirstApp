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
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));

        Console.WriteLine($"Your name is {name} and age is {age}");

        Console.Write("What is your favorite days of week? ");
        DaysOfWeek day = (DaysOfWeek)byte.Parse(Console.ReadLine());
        Console.WriteLine($"Your favorite day is {day}");

        Console.ReadKey();
	}
}