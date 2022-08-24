using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        // Подготовка данных
        var cars = new List<Car>()
        {
           new Car("Suzuki", "JP"),
           new Car("Toyota", "JP"),
           new Car("Opel", "DE"),
           new Car("Kamaz", "RUS"),
           new Car("Lada", "RUS"),
           new Car("Lada", "RUS"),
           new Car("Honda", "JP"),
        };

        Console.WriteLine("Пропустим японские машины в начале списка");
        var notJPCar = cars.SkipWhile(c => c.CountryCode == "JP");

        foreach(var car in notJPCar)
            Console.WriteLine(car.Manufacturer);
        Console.WriteLine();

        Console.WriteLine("Теперь выберем только японские машины из начала списка");
        var JPCar = cars.TakeWhile(c => c.CountryCode == "JP");

        foreach(var car in JPCar)
            Console.WriteLine(car.Manufacturer);

    }   
}

public class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }

    public Car(string manufacturer, string countryCode)
    {
        Manufacturer = manufacturer;
        CountryCode = countryCode;
    }
}