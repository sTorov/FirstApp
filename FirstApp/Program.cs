using System;

class FirstApp
{
    //static int[] GetArrayFromConsole(int num = 5)
    //{
    //    int[] array = new int[num];
        
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Console.Write($"Введите занчение {i + 1}: ");
    //        array[i] = int.Parse(Console.ReadLine());
    //    }
    //    return array;
    //}

    //static int[] SortArray(int[] array)
    //{
    //    int temp = 0;
        
    //    for (int i = 0; i < array.Length; i++)
    //        for (int j = i + 1; j < array.Length; j++)
    //            if (array[i] > array[j])
    //            {
    //                temp = array[i];
    //                array[i] = array[j];
    //                array[j] = temp;
    //            }
    //    return array;
    //}

    //static void ShowArray(int[] array, bool sort = false)
    //{
    //    var temp = array;

    //    if(sort)
    //        SortArray(temp);
        
    //    foreach (var number in temp)
    //        Console.Write(number + " ");
    //}

    static int Sum (int a, int b, bool log = true, int c = 10)
    {
        int res = a + b + c;
        if(log)
            Console.WriteLine($"{a} + {b} + {c} = {res}");
        else
            Console.WriteLine(res);

        return res;
    }
    static void Main(string[] args)
    {
        //var array = GetArrayFromConsole();
        //var sortedarray = SortArray(array); 

        //int[] myArray = SortArray(GetArrayFromConsole(2));

        //var array = GetArrayFromConsole();
        //ShowArray(array);
        //Console.WriteLine();
        //ShowArray(array, true);

        //var array = GetArrayFromConsole(10);
        //ShowArray(array, true);

        var result = Sum(3, 3, c:4);

        Console.ReadLine();
    }
   
}