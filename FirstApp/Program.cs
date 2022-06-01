using System;

class FirstApp
{
	static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = (byte) int.Parse(Console.ReadLine());
        Console.WriteLine($"Your name is {name} and age is {age}");

        Console.ReadKey();
	}
}