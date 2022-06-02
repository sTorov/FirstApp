using System;

class FirstApp
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        Console.Write("Enter your age: ");
        var age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your name is {name} and age is {age}");

        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine($"Your birthdate is {birthdate}");

        Console.ReadKey();
	}
}