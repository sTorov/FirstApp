class Program
{
	static void Main()
	{
		int[] ints = new int[5];
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

		int result = BinarySearchRecurs(5, ints, 0, ints.Length - 1);
		string s;
		Console.WriteLine(s = result != -1 ? "индекс: " + result : "NaN");
		Console.ReadKey();
	}

	static int BinarySearchRecurs(int value, int[] array, int left, int right)
    {
		int middle = (left + right) / 2;
		
		int midElement = array[middle];

		if(midElement == value)
			return middle;

		if(left < right)
        {
			if(value < midElement)
				return BinarySearchRecurs(value, array, left, middle - 1);
			
			return BinarySearchRecurs(value, array, middle + 1, right);
        }

		return -1;
    }
}