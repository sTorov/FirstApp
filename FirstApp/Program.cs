using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetUpperBound(0));

            //GetLength

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[j, i] + "\t");
                }
                Console.WriteLine();
            }

            //GetUpperBound

            Console.WriteLine();

            for (int i = 0; i <= array.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(0); j++)
                {
                    Console.Write(array[j, i] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}