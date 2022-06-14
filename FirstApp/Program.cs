using System;

class FirstApp
{
    static void GetName(string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        var someName = "Евгения";
        Console.WriteLine(someName);

        GetName(someName);

        Console.WriteLine(someName);

        Console.ReadLine();
    }
}