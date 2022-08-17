using System.Collections;
using System.Text;

/*
 * ExceptWith() Удаляет из хэш-сета все элементы, содержащиеся в другой коллекции.
 */

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;
        
        //Создадми словарь, ключём будет строка, значение - массив строк
        var cities = new Dictionary<string, string[]>(3/*Размер указывать не обязательно*/);

        //Добавим новые значения
        cities.Add("Россия", new[] {"Москва", "Санкт-Петербург", "Волгоград"});
        cities.Add("Украина", new[] {"Киев", "Львов", "Николаев"});
        cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно"});

        //Посмотрим всё что есть в словаре
        foreach (var citiesByCountry in cities)
        {
            Console.Write(citiesByCountry.Key + ": ");
            foreach (var city in citiesByCountry.Value)
                Console.Write(city + " ");

            Console.WriteLine();
        }

        Console.WriteLine();

        //Теперь попробуем вывести значение по ключу
        var russianCities = cities["Россия"];
        Console.WriteLine("Города России:");
        foreach (var city in russianCities)
            Console.WriteLine(city);

        Console.WriteLine();

        //изменение значения по ключу
        cities["Россия"] = new[] { "Мурманск", "Казань"};

        //удаление по ключу
        cities.Remove("Беларусь");

        //Посмотрим всё что есть в словаре после преобразований
        foreach (var citiesByCountry in cities)
        {
            Console.Write(citiesByCountry.Key + ": ");
            foreach (var city in citiesByCountry.Value)
                Console.Write(city + " ");

            Console.WriteLine();
        }

    }
}