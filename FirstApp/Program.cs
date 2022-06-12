using System;

class FirstApp
{
    static int[] GetArrayFromConsole()
    {
        int[] array = new int[5];
        
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
        //int[] array = GetArrayFromConsole();
        //SortArray(array);
                
        int[] myArray = SortArray(GetArrayFromConsole());

        foreach (var item in myArray)
            Console.Write(item + " ");

        Console.ReadLine();
    }
   
}