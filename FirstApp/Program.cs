using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
        string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

        //Объеденим без дубликатов
        var vehicles = cars.Union(buses);

        foreach (var v in vehicles)
            Console.WriteLine(v);
        Console.WriteLine();

        //Объеденим с дубликатами
        var vehicles2 = cars.Concat(buses);

        foreach (var v in vehicles2)
            Console.WriteLine(v);
        Console.WriteLine();

        //Удалим дубликаты
        var uniqueCars = vehicles2.Distinct();

        foreach(var v in uniqueCars)
            Console.WriteLine(v);

        //Равносильно  cars.Concat(buses).Distinct() == cars.Union(buses)
    }
}
