class Program
{
	static void Main()
	{
		int[] ints = new int[3];
		Random random = new();
		int temp = 0;

		for(int i = 0; i < ints.Length; i++)
        {
			temp = random.Next(0, 10);
			if (!Array.Exists(ints, s => s == temp))
            {
				ints[i] = temp;
				continue;
            }

			i--;
        }
		Array.Sort(ints);

		foreach(var num in ints)
			Console.Write(num + " ");
		Console.WriteLine();

		int result = BinarySearch(5, ints, 0, ints.Length - 1);
		string s;
		Console.WriteLine(s = result != -1 ? "индекс: " + result : "NaN");
		Console.ReadKey();
	}

	static int BinarySearch(int value, int[] array, int left, int right)
    {
		int middle, midElement;

		do
		{
			middle = (left + right) / 2;

			midElement = array[middle];

			if (midElement == value)
				return middle;
			else if (value < midElement)
				right = middle - 1;
			else
				left = middle + 1;			
		}
		while (left <= right);

		return -1;
	}
}