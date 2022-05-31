using System;

class FirstApp
{
	enum Semaphore
	{
		Red =100,
		Yellow =200,
		Green = 300
	}

	static void Main(string[] args)
    {
		Semaphore Color;

		Color = Semaphore.Yellow;

		Console.WriteLine(Color);

		Console.ReadLine();
    }
}