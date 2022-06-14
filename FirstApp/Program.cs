using System;

class FirstApp
{
    static int num1 = 667;
    
    static int Sum()
    {
        var num2 = 1;
        return num1 - num2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(num1);
        Console.WriteLine(Sum());
        if (num1 > 0)
        {
            var num3 = 5;
            Console.WriteLine(num1 + num3);
        }

        Console.ReadLine();
    }
}