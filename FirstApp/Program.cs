using System.Collections;
using System.Text;

/*
 * ExceptWith() Удаляет из хэш-сета все элементы, содержащиеся в другой коллекции.
 */

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF7;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        while (true)
        {
            Console.WriteLine("Введите любой текст");
            string str = Console.ReadLine();
            Analizer(str);
            Console.ReadKey();
            Console.Clear();
        }        
    }

    static void Analizer(string words)
    {
        HashSet<char> chars = new HashSet<char>();

        chars.UnionWith(words);

        Console.WriteLine("Количество уникальных символов: " + chars.Count);
        Console.WriteLine("Наличие цифр: " + chars.Overlaps(new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }));

        chars.ExceptWith(new char[] { ' ', ',', '.' });

        Console.WriteLine("Количество уникальных символов без знаков препинания: " + chars.Count);
    }
}