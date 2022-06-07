using System;

class FirstApp
{
    static void Main(string[] args)
    {
        var (name, age, birthdate) = ("Dima", 26, "10.03.1996");

        Console.WriteLine($"Your name is {name}");
        Console.WriteLine($"Your age is {age}");
        Console.WriteLine($"Your birthdate is {birthdate}");

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter your birthdate: ");
        birthdate = Console.ReadLine();

        Console.WriteLine($"Your name is {name} and age is {age}");
        Console.WriteLine($"Your birthdate is {birthdate}");

        Console.ReadKey();
	}
}