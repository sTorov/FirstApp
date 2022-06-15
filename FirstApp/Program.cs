using System;

class FirstApp
{   
    static decimal Factorial(int x)
    {
        if (x == 0)
            return 1;
        else
            return x * Factorial(x - 1);
    }

    static void Main(string[] args)
    {
        int x = 20;

        Console.WriteLine(Factorial(x));

        Console.ReadLine();
    }
}