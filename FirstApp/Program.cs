using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Введите любой текст");
        string stroka = Console.ReadLine();

        if(string.IsNullOrEmpty(stroka))
        {
            Console.WriteLine("Вы ввели пустую строку!");
            return;
        }

        var uniqueLetters = stroka
            .Where(s => !char.IsPunctuation(s) && s != ' ')
            .Distinct()
            .ToArray();

        Console.WriteLine(uniqueLetters);
    }    
}
