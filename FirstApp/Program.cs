using System;

class FirstApp
{
    static int[] GetArrayFromConsole(int num = 5)
    {
        int[] array = new int[num];
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите занчение {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int[] SortArray(int[] array)
    {
        int temp = 0;
        
        for (int i = 0; i < array.Length; i++)
            for (int j = i + 1; j < array.Length; j++)
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
        return array;
    }

    static void Main(string[] args)
    {
        var array = GetArrayFromConsole();
        var sortedarray = SortArray(array);

        //int[] myArray = SortArray(GetArrayFromConsole(2));

        foreach (var item in sortedarray)
            Console.Write(item + " ");

        Console.ReadLine();
    }
   
}