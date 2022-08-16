using System.Collections;
using System.Text;

/*
 * Специфичный метод. Изменяет HashSet<T> таким образом, 
 * чтобы он содержал только те элементы, которые есть в нём 
 * самом или otherCollection, исключая дубликаты на уровне обеих коллекций.
 */

class Program
{
    static void Main()
    {
        var hSet  = new HashSet<string>()
        {
            "Иван", "Дмитрий"
        };

        hSet.SymmetricExceptWith(new[] {"Дмитрий", "Сергей", "Игорь" });

        Console.WriteLine("Элементы после объединения с новой коллекцией");
        foreach(var i in hSet)
            Console.WriteLine(i);

    }
}