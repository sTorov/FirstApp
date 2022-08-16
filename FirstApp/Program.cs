using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        string[] names =
        {
            "Игорь",        //повтор
            "Андрей",
            "Василий",
            "София",
            "Елена",
            "Анна",
            "Игорь"         //повтор
        };

        //выведем длину массива в консоль
        Console.WriteLine("Длина массива " + names.Length + "\n");
        Console.WriteLine("Данные в массиве");
        foreach(string name in names)
            Console.WriteLine(name);
        Console.WriteLine();

        //создаём хеш-сет, передавая в конструктор наш массив
        HashSet<string> set = new HashSet<string>(names);
        //посчитаем объекты в массиве
        Console.WriteLine("Длина хеш-сета " + set.Count + "\n");
        //выведем элементы в консоль, посмотрим, есть ли дубликаты
        Console.WriteLine("Элементы хеш-сета");
        foreach(var obj in set)
            Console.WriteLine(obj);
    }
}