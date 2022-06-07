using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 9, 9, 4, 1, 2, 3, 4, 9 };
            int[] sort = new int [arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                int index = 0;
                int copy = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        index++;
                    if (arr[i] == arr[j])
                        copy++;
                }
                if (copy == 1)
                    sort[index] = arr[i];
                else
                    for (int k = index; k < index + copy; k++)
                    {
                        sort[k] = arr[i];
                    }
            }

            for (int i = 0; i < sort.Length; i++)
            {
                Console.Write(sort[i] + " ");
            }

            //Правильный вариант

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}