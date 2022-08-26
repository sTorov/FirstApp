using System.Text;

class Program
{
    //Нахождение общих элементов коллекций

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //поищем машины, которые можно считать микроавтобусами
        var microBuses = cars.Intersect(buses);

        foreach (var mb in microBuses)
            Console.WriteLine(mb);
    }
}
