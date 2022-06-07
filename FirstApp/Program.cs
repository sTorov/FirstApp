using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Сумма всех элементов: " + sum);

            Console.ReadKey();
        }
    }
}