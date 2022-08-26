using System.Text;

class Program
{
    //Исключение из одной коллекции содержимого другой коллекции

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Список напитков в продаже
        string[] drinks = { "Вода", "Коко-кола", "Лимонад", "Вино" };
        //Алкогольные напитки
        string[] alcohol = { "Вино", "Пиво", "Сидр" };
        
        //Убираем алкогольные напитки из асортимента
        var drinksForKids = drinks.Except(alcohol);

        foreach(var drink in drinksForKids)
            Console.WriteLine(drink);
        Console.WriteLine();

        //Важно! Метод Except() возвращает только уникальные элементы.
        //("Вода" в примере ниже выведится один раз)
        string[] drinks2 = { "Вода", "Вода", "Кока-кола", "Лимонад", "Вино" };
        var drinksForKids2 = drinks2.Except(alcohol);

        foreach(var drink in drinksForKids2)
            Console.WriteLine(drink);
    }
}
