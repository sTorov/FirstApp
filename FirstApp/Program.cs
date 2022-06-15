using System;

class FirstApp
{   
    static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
            return 1;
        else if (pow == 1)
            return N;
        else
            return N * PowerUp(N, --pow);
    }

    static void Main(string[] args)
    {
        int x = 2;

        Console.WriteLine(PowerUp(x, 10));

        Console.ReadLine();
    }
}