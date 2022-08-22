using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        string[] text = 
        { 
            "Раз два три",
            "четыре пять шесть",
            "семь восемь девять" 
        };

        var words = from str in text //пробегаемся по всем элементам массива
                    from word in str.Split(' ') //дробим каждый элемент по пробелам, сохраняя в новую последовательность
                    select word; //собираем все куски в результирующую выборку

        //выводим результат
        foreach(var word in words)
            Console.WriteLine(word);
    }
}
