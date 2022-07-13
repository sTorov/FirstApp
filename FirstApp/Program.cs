class Car
{
    public string Model { get; set; }
}
class BMW : Car { }

class Program
{
    delegate void BMWInfo (BMW bmw);
    static void Main()
    {
        BMWInfo bmwinfo = GetCarInfo;
        BMW bmw = new BMW { Model = "X6" };     //контравариативность
        bmwinfo(bmw);
        Console.ReadLine();
    }
    private static void GetCarInfo(Car p)
    {
        Console.WriteLine(p.Model);
    }
}