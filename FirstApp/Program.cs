using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой ваш любимый цвет?");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;         //Цвет фона текста в консоли
                Console.ForegroundColor = ConsoleColor.Black;       //Цвет шрифта
                Console.WriteLine("Ваш любимый цвет красный!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш любимый цвет зеленый!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Ваш любимый цвет бирюзовый!");
            }

            Console.ReadLine();
        }
    }
}