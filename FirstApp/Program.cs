using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("FOR\n");
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Какой ваш любимый цвет?");
                Console.WriteLine(i); 
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;         //Цвет фона текста в консоли
                        Console.ForegroundColor = ConsoleColor.White;       //Цвет шрифта
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

            Console.WriteLine("\nWHILE\n");
            
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("Какой ваш любимый цвет?");
                Console.WriteLine(k);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;         //Цвет фона текста в консоли
                        Console.ForegroundColor = ConsoleColor.White;       //Цвет шрифта
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
                k++;
            }

            Console.WriteLine("\nDO WHILE\n");

            int t = 0;
            do
            {
                Console.WriteLine("Какой ваш любимый цвет?");
                Console.WriteLine(t);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;         //Цвет фона текста в консоли
                        Console.ForegroundColor = ConsoleColor.White;       //Цвет шрифта
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

                t++;
            } while (t < 3);

            Console.ReadLine();
        }
    }
}