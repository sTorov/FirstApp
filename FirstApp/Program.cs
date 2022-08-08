class Program
{
    static void Main()
    {
        int[] ints = new int[] { 1, 3, 3, 5, 6, 7, 7, 10 };
        int[] ints2 = GetArray(ints, 7);

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
        for (int i = index; i < array.Length; i++)
            newArray[i + 1] = array[i];

        return newArray;
    }

    static int GetInsertIndex(int[] array, int value)
    {
        int subStart = array[0] - value;
        if (subStart >= 0)
            return 0;

        int subEnd = array[array.Length - 1] - value;
        if (subEnd <= 0)
            return array.Length;

        int mult = 1;
        int subMid = array[(array.Length - 1) / 2] - value;
        if (subMid == 0)
            return (array.Length - 1) / 2;
        if(subMid < 0)
            mult = -1;

        if (subStart < subEnd && subStart < subMid * mult)
            return Front(array, value, 0, (array.Length - 1) / 2);
        else if (subEnd < subStart && subEnd < subMid * mult)
            return Back(array, value, array.Length - 1, (array.Length - 1) / 2);
        else if (subMid < 0)
            return Front(array, value, (array.Length - 1) / 2, array.Length - 1);
        else
            return Back(array, value, (array.Length - 1) / 2, 0);


    }

    static int Back(int[] array, int value, int start, int end)
    {
        for (int i = start; i >= end; i--)
            if (array[i] > value)
                return i;

        return start;
    }

    static int Front(int[] array, int value, int start, int end)
    {
        for (int i = start; i <= end; i++)
            if (array[i] > value)
                return i;

        return start;
    }
}