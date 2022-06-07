using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            string[] favcolor = new string[3];

            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine($"Введите ваш любимый цвет {i + 1}: ");
                favcolor[i] = Console.ReadLine();
            }

            foreach (var color in favcolor)
            {
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ваш любимый цвет красный!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет зеленый!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш любимый цвет бирюзовый!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш любимый цвет желтый!");
                        break;
                }
            }
         
            Console.ReadLine();
        }
    }
}