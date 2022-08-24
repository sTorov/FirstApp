using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };

        //пропустим первые 2 элемента
        var skip2 = cars.Skip(2);

        foreach(var car in skip2)
            Console.WriteLine(car);
        Console.WriteLine();

        //пропустим первые 2 и добавим следующие 2
        var skipTake = cars.Skip(2).Take(2);

        foreach(var car in skipTake)
            Console.WriteLine(car);
    }   
}