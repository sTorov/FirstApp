using System;

class FirstApp
{   
    static void Echo(string phrase, int deep)
    {
        if(phrase.Length > 2)
            phrase = phrase.Remove(0, 2);

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine(".." + phrase);

        if (deep > 1)
            Echo(phrase, --deep);       //depp - 1
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу");
        string str = Console.ReadLine();

        Console.WriteLine("Глубина эха");
        int deep = int.Parse(Console.ReadLine());

        Console.WriteLine(str);
        Echo(str, deep);

        Console.ResetColor();

        Console.ReadLine();
    }
}