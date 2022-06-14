using System;

class FirstApp
{
	public static void Main(string[] args)
	{
		var arr = new int[] { 1, 2, 3 };
		var data = 10;
		BigDataOperation(arr, data);

		Console.WriteLine(arr[0]);
	}

	static void BigDataOperation(int[] arr,in int data)
	{
		data = 4;
		arr[0] = data;
	}

}