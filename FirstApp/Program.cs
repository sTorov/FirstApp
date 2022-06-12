using System;

class FirstApp
{
    static void ShowColors(string[] favcolor)
    {
        Console.ResetColor();

        Console.WriteLine("\nВаши любимые цвета:");
        foreach (var color in favcolor)
            Console.WriteLine(color);
    }
    
    static string Color(string username, int userage)
    {
        Console.WriteLine($"{username}, возраст {userage}\n Какой ваш любимый цвет? (eng)");
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
        (string name, int age) anketa;

        Console.Write("Введите имя: ");
        anketa.name = Console.ReadLine();
        Console.Write("Введите возраст: ");
        anketa.age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Ваше имя {anketa.name}\nВаш возраст {anketa.age}\n");

        string[] favcolor = new string[3];
        for (int i = 0; i < favcolor.Length; i++)
            favcolor[i] = Color(anketa.name, anketa.age);
               
        ShowColors(favcolor);

        Console.ReadLine();
    }
   
}