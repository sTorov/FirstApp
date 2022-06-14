using System;

class FirstApp
{
    static void SortArray(in int[] array, out int[] arrayAsc, out int[] arrayDesc)
    {
        arrayAsc = SortArrayAsc(array);
        arrayDesc = SortArrayDesc(array);
    }

    static int[] SortArrayAsc(int[] array)
    {
        int[] sortarray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            sortarray[i] = array[i];
        int temp = 0;

        for (int i = 0; i < sortarray.Length; i++)
            for (int j = i + 1; j < sortarray.Length; j++)
                if (sortarray[i] > sortarray[j])
                {
                    temp = sortarray[i];
                    sortarray[i] = sortarray[j];
                    sortarray[j] = temp;
                }
        return sortarray;
    }

    static int[] SortArrayDesc(int[] array)
    {
        int[] sortarray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
            sortarray[i] = array[i];
        int temp = 0;

        for (int i = 0; i < sortarray.Length; i++)
            for (int j = i + 1; j < sortarray.Length; j++)
                if (sortarray[i] < sortarray[j])
                {
                    temp = sortarray[i];
                    sortarray[i] = sortarray[j];
                    sortarray[j] = temp;
                }
        return sortarray;
    }

    public static void Main(string[] args)
	{
        int[] myArray = { 3, 34, 12, 43, 1, 8, 0 };
        
        Console.WriteLine("MyArray");
        foreach (var item in myArray)
            Console.Write(item + " ");

        SortArray(myArray, out int[] AscMyArray, out int[] DescMyArray);

        Console.WriteLine("\n\nAscMyArray");
        foreach (var item in AscMyArray)
            Console.Write(item + " ");

        Console.WriteLine("\n\nDescMyArray");
        foreach (var num in DescMyArray)
            Console.Write(num + " ");

        Console.ReadLine();
    }
	
}