using System;

class FirstApp
{
    static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;

        Console.Write("Введите имя: ");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите 5 любимых блюд");
        User.Dishes = new string[5];
        for (int i = 0; i < User.Dishes.Length; i++)
        {
            Console.Write($"Блюдо {i + 1}: ");
            User.Dishes[i] = Console.ReadLine();
        }

        Console.ReadLine();
    }
}