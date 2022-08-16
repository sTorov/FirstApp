using System.Collections;
using System.Text;

/*
 * ExceptWith() Удаляет из хэш-сета все элементы, содержащиеся в другой коллекции.
 */

class Program
{
    static void Main()
    {
        //Создадим два множества
        SortedSet<char> lettersOne = new SortedSet<char>();
        SortedSet<char> lettersTwo = new SortedSet<char>();

        //Добавим элементы в первую
        lettersOne.Add('A');
        lettersOne.Add('B');
        lettersOne.Add('C');
        lettersOne.Add('Z');

        //выведим
        PrintCollection(lettersOne, "Первая коллекция");

        //Добавим элементы во вторую коллекцию
        lettersTwo.Add('Y');
        lettersTwo.Add('X');
        lettersTwo.Add('Z');

        //выведим
        PrintCollection(lettersTwo, "Вторая коллекция");

        //Выполним вычитание множеств
        lettersOne.ExceptWith(lettersTwo);

        //выведим результат
        PrintCollection(lettersOne, "Результат вычитания");
    }

    static void PrintCollection(SortedSet<char> chars, string s)
    {
        Console.WriteLine(s);
        foreach (var item in chars)
            Console.Write(item + " ");
        Console.WriteLine("\n");
    }
}