using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        //Создадим сортированный словарь
        SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();

        //Добавим несколько элементов в случайном порядке
        sortedDictionary.Add("zebra", 5);
        sortedDictionary.Add("cat", 2);
        sortedDictionary.Add("dog", 9);
        sortedDictionary.Add("mouse", 4);
        sortedDictionary.Add("programmer", 100);

        //Ищем зебру
        if(sortedDictionary.ContainsKey("zebra"))
            Console.WriteLine("Нашли зебру");
        //Ищем собаку
        if(sortedDictionary.ContainsKey("dog"))
            Console.WriteLine("Нашли собаку");
        //Ищем обезьяну
        if(sortedDictionary.ContainsKey("ape"))
            Console.WriteLine("Нашли обезьяну");

        Console.WriteLine();
        //Выведем коллекцию
        Console.WriteLine("Посмотрим всех:");

        foreach(KeyValuePair<string, int> p in sortedDictionary)
            Console.WriteLine($"{p.Key} = {p.Value}");
    }
}
