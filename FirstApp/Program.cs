using System;

class FirstApp
{
	static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is {age}");

        Console.ReadKey();
	}
}