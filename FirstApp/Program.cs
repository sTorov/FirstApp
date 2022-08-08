class Program
{
    static void Main()
    {
        int[] ints = new int[] { 1, 2, 3, 5, 6, 7 };
        int[] ints2 = GetArray(ints, 2);

        Console.WriteLine(String.Join(", ", ints));
        Console.WriteLine(String.Join(", ", ints2));


        Console.ReadKey();
    }

    static int[] GetArray(int[] array, int value)
    {
        int[] newArray = new int[array.Length + 1];
        int index = GetInsertIndex(array, value);

        newArray[index] = value;

        for (int i = 0; i < index; i++)
            newArray[i] = array[i];
        for(int i = index; i < array.Length; i++)
            newArray[i + 1] = array[i];

        return newArray;
    }

    static int GetInsertIndex(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;
        int middle = 0;

        while (left <= right)
        {
            middle = (left + right) / 2;

            if (array[middle] > value)
                right = middle - 1;
            else if (array[middle] < value)
                left = middle + 1;
            else
                return middle;
        }
        return middle;
    }    
}