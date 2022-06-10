using System;

class FirstApp
{
    class Logic
    {
        static string ShowColor()
        {
            Console.WriteLine("Какой ваш любимый цвет? (eng)");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your color is " + color);
                    return color;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is " + color);
                    return color;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is " + color);
                    return color;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is yellow");
                    return color;
            }
        }

        static void Main(string[] args)
        {
            string[] favcolor = new string[3];
            for (int i = 0; i < favcolor.Length; i++)
                favcolor[i] = ShowColor();
            
            Console.ResetColor();

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolor)
                Console.WriteLine(color);

            Console.ReadLine();
        }
    }
}