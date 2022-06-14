using System;

class FirstApp
{
    static void ChangeAge(int age)
    {
        Console.WriteLine("Введите возраст");
        age = int.Parse(Console.ReadLine());
    }
    
    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
    }
    
    static void Main(string[] args) 
    {
        var someName = "Евгения";
        var age = 25;
        Console.WriteLine(someName);
        Console.WriteLine(age);

        GetName(ref someName);
        ChangeAge(age);

        Console.WriteLine(someName);
        Console.WriteLine(age);

        Console.ReadLine();
    }
}