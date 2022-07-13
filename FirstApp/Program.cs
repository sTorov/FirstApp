class Car
{
    public string Model { get; set; }
}
class BMW : Car { }

class Program
{
    delegate Car CarDelegate (string name);
    static void Main()
    {
        CarDelegate carDelegate;
        carDelegate = BuildBMW;     //ковариантность
        Car c = carDelegate("X6");
        Console.WriteLine(c.Model);
        Console.ReadLine();
    }
    private static BMW BuildBMW(string model)
    {
        return new BMW { Model = model};
    }
}