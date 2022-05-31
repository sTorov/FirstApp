using System;

class FirstApp
{
	enum DaysOfWeek : byte
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
		DaysOfWeek MyFavoriteDay;

		MyFavoriteDay = DaysOfWeek.Sunday;

		Console.WriteLine(MyFavoriteDay);

		Console.ReadLine();
    }
}