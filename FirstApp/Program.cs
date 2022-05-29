using System;

class FirstApp
{
	static void Main(string[] args)
	{

		const string myName = "Dima";

		Console.WriteLine(myName);

		Console.WriteLine("\tПривет, мир");
		Console.WriteLine("\tМне 26 лет");
		Console.WriteLine("\tMy name is\n Dima");
        Console.WriteLine('\u0040');
        Console.WriteLine('\x23');

		Console.ReadKey();
	}
}