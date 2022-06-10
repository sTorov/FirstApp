using System;

class FirstApp
{
    class Logic
    {
        static void ShowColor()
        {
            Console.WriteLine("Какой ваш любимый цвет? (eng)");
            string color = Console.ReadLine();

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

        static void Main(string[] args)
        {
            var (name, age) = ("Dima", 26);

            Console.WriteLine($"Ваше имя {name}");
            Console.WriteLine($"Ваш возраст {age}");

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ваше имя {name}");
            Console.WriteLine($"Ваш возраст {age}");

            ShowColor();

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}