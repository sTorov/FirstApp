class Program
{
	static void Main()
	{
		int[] ints = new int[] { 12, 3, 4, 54, 23, 9, 10, 10 ,0 , 6};
		int[] sortedArray = QuickSort(ints, 0, ints.Length - 1);

        Console.WriteLine($"Отсортированный массив: {string.Join(", ", sortedArray)}");

		Console.ReadKey();
	}

	static int[] QuickSort(int[] array, int minIndex, int maxIndex)
	{
		if(minIndex >= maxIndex)
			return array;
		
		int pivotIndex = GetPivotIndez(array, minIndex, maxIndex);

		QuickSort(array, minIndex, pivotIndex - 1);		
		QuickSort(array, pivotIndex + 1, maxIndex);
		
		return array;
	}

	static int GetPivotIndez(int[] array, int minIndex, int maxIndex)
    {
		int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
			if (array[i] < array[maxIndex])
            {
				pivot++;
				Swap(ref array[pivot], ref array[i]);
            }
        }

		pivot++;
		Swap(ref array[pivot], ref array[maxIndex]);

		return pivot;
    }

	static void Swap(ref int leftItem, ref int rightItem)
    {
		int temp = leftItem;
		leftItem = rightItem;
		rightItem = temp;
    }
}