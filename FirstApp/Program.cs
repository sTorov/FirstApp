using System;

class FirstApp
{
	static void Main(string[] args)
	{

		string myName = "Dima";
		byte myAge = 26;
		bool myPet = false;
		double myLeg = 40.5;

		Console.WriteLine($"My name is {myName}");
		Console.WriteLine($"My age is {myAge}");
		Console.WriteLine($"Do I have a pet? {myPet}");
        Console.WriteLine($"My shoe size is {myLeg}");
        
		Console.ReadKey();
	}
}