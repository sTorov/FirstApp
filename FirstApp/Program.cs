using System;

class FirstApp
{
    class Logic
    {
        static int[] GetArrayFromConsole()
        {
            int temp;
            int[] number = new int[5];
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Значение {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
                for (int j = i + 1; j < number.Length; j++)
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
            
            Console.WriteLine("\nСортировка по возрвстанию");
            foreach (var item in number)
                Console.Write(item + "\t");

            return number;
        }

        static void Main(string[] args)
        {
            GetArrayFromConsole();

            Console.ReadLine();
        }
    }
}