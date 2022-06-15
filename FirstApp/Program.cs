using System;

class FirstApp
{   
    static void Echo(char[] modif, int deep, int h = 0)
    {
        Console.Write("...");
        for (int i = h; i < modif.Length; i++)
        {
            Console.Write(modif[i]);
        }
        Console.WriteLine();

        if (deep > 1)
            Echo(modif, --deep, h + 2);       //depp - 1
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите фразу");
        string str = Console.ReadLine();
        char[] modif = new char[str.Length];
        int i = 0;
        foreach (var item in str)
        {
            modif[i] = item;
            i++;
        }

        Console.WriteLine("Глубина эха");
        int deep = int.Parse(Console.ReadLine());

        Echo(modif, deep);

        Console.ReadLine();
    }
}