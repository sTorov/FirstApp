using System;

class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue)
            Console.WriteLine($"Пассажиров в автобусе - {Load.Value}");
        else
            Console.WriteLine("Автобус пуст");
    }
}

class Progarm
{
    static void Main(string[] args)
    {
        Bus bus = new();
        bus.PrintStatus();

        bus = new Bus { Load = 10 };
        bus.PrintStatus();
    }
}