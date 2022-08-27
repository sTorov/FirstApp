using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine(Factorial(5));
        //или
        Console.WriteLine(Factorial2(5));
    }

    static long Factorial(int number)
    {
        long[] numbers = new long[number];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = i + 1;

        long result = numbers.Aggregate((x, y) => x * y);
        return result;
    }

    //Решение
    static long Factorial2(int number)
    {
        //Коллекция для хранения чисел
        var numbers = new List<long>();
        
        //Добавляем все числа от 1 до n в коллекцию
        for (int i = 1; i <= number; i++)
            numbers.Add(i);

        //Выполняем агрегацию
        return numbers.Aggregate((x, y) => x * y);        
    }
}
