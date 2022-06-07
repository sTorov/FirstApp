using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[2] { 1, 2 };
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var array in arr)
            {
                foreach (var number in array)
                {
                    Console.Write(number + " ");
                }
            }

            Console.ReadKey();
        }
    }
}