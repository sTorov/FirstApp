using System;

class FirstApp
{
	static void Main(string[] args)
	{
		int counter = 10;
		Console.WriteLine("Value: {0} Increment: {1}\n", counter, counter++);
        Console.WriteLine($"Post_Increment: {counter}");

		Console.ReadKey();
	}
}