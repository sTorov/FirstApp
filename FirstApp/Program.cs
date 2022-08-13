class Program
{
    static void Main()
    {
        int[] sort = { 1, 3, 5, 7, 8};
        int[] nonSort = { 1, 3, 1, 1, 5 };

        Console.WriteLine(ChechArraySortIncreasing(sort));
        Console.WriteLine(ChechArraySortIncreasing(nonSort));
    }

    static bool ChechArraySortIncreasing(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
            if (array[i] > array[i + 1])
                return false;

        return true;
    }
}