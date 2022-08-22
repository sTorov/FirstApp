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
        Console.WriteLine();

        //Задание 14.1.1
        var shortNameCity = from c in russianCities
                           where c.Name.Length <= 10
                           orderby c.Name.Length descending
                           select c;

        foreach(var c in shortNameCity)
            Console.WriteLine(c.Name);
        Console.WriteLine();

        var SNC = russianCities
            .Where(c => c.Name.Length <= 10)
            .OrderByDescending(c => c.Name.Length);

        foreach( var c in SNC)
            Console.WriteLine(c.Name);
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
