class Program
{
	static void Main()
	{
		Console.WriteLine("Сколько элементов будет в массиве?");
		var count = Int32.Parse(Console.ReadLine());

		var array = new int[count];

		for (int i = 0; i < count; i++)
		{
			array[i] = Int32.Parse(Console.ReadLine());
		}

		Console.WriteLine("Все элементы записаны");
	}
}