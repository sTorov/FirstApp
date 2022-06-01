using System;

class FirstApp
{
	static void Main(string[] args)
	{
		int counter = 10;
		Console.WriteLine("Value: {0} Pref_Increment: {1}", counter, ++counter);

		Console.ReadKey();
	}
}