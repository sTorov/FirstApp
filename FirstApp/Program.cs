using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        //Добавим Россию с её городами
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));

        //Выберем города-милионники
        var bigCities = from russianCity in russianCities
                        where russianCity.Population > 1000000
                        orderby russianCity.Population descending
                        select russianCity;

        foreach(var bigCity in bigCities)
            Console.WriteLine(bigCity);
        Console.WriteLine();

        //Или
        var cities = russianCities.Where(city => city.Population > 1000000)
            .OrderByDescending(city => city.Population);

        foreach(var c in cities)
            Console.WriteLine(c);
    }

    //Создадим модель-класс для города
    public class City
    {
        public string Name { get; set; }
        public long Population { get; set; }

        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return Name + " - " + Population;
        }
    }
}
