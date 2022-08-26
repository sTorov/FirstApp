using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string word1 = "Hello";
        string word2 = "world";

        Console.WriteLine("Общие буквы: " + CommonLetter(word1, word2));
    }

    static int CommonLetter(string word1, string word2)
    {
        //ищем пересечения
        var letters = word1.Intersect(word2);

        foreach(var letter in letters)
            Console.WriteLine(letter);

        //возвращаем количество
        return letters.Count();
    }
}
