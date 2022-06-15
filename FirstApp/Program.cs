using System;

class FirstApp
{   
    static void Echo(string phrase)
    {
        Console.WriteLine(phrase);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу");
        string str = Console.ReadLine();

        Console.WriteLine("Глубина эха");
        int deep = int.Parse(Console.ReadLine());

        for (int i = 0; i < deep; i++)
            Echo(str);

        Console.ReadLine();
    }
}