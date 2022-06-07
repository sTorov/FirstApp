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
                
            int positive = 0;

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
                    if (array[i, j] > 0)
                        positive++;
                }
            }

            Console.WriteLine("Количество положительных элементов: " + positive);
            
            // foreach
            positive = 0;

            foreach (var item in array)
            {
                if (item > 0)
                    positive++;
            }

            Console.WriteLine("Количество положительных элементов: " + positive);

            Console.ReadLine();
        }
    }
}