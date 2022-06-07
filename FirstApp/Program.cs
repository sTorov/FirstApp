using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, -1, -5, 0, -6, 1, -4 };
            int positive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    positive++;
            }

            Console.WriteLine("Количество положительных элементов: " + positive);
            Console.ReadLine();
        }
    }
}