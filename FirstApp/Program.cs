using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 1, 2, 3, 4, -1, -5 },
                { -12, 4, 0, 0, 3, -5}
            };

            int temp;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if(array[i, j] > array[i, k])
                        {
                            temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}