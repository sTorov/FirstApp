using System.Collections;
using System.Text;

/*
 * ExceptWith() Удаляет из хэш-сета все элементы, содержащиеся в другой коллекции.
 */

class Program
{
    static void Main()
    {
        string words = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
        HashSet<char> chars = new HashSet<char>();
        chars.UnionWith(words);
        Console.WriteLine(chars.Count);
        Console.WriteLine(chars.Overlaps(new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'}));
        chars.ExceptWith(new char[] {' ', ',', '.'});
        Console.WriteLine(chars.Count);
    }
}