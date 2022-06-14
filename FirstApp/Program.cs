using System;

class FirstApp
{
	static void BigDataOperation(int[] arr, ref int data)
	{
		data = 4;
		arr[0] = data;
	}

	static int[] GetArrayFromConsole(ref int size) 
	{
		size = 6;
		int[] array = new int[size];

		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($"Введите занчение {i + 1}: ");
			array[i] = int.Parse(Console.ReadLine());
		}
		return array;
	}
	public static void Main(string[] args)
	{
		int size = 5;

		GetArrayFromConsole(ref size);

        Console.WriteLine(size);	
	}
	
}