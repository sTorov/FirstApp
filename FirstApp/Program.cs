class Program
{
    static void Main()
    {
        int[,] myArray =
        {
           { 5, 8, 3, 10 },
           { 13, 2, 1, 7 },
           { 0, 2, 5, 2 },
           { 3, 8, 3, 45 },
           { 2, 4, 31, 4 }
        };

        PrintArray(myArray);
    }

    static void PrintArray(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + "\t");

            Console.WriteLine();
        }
    }
}