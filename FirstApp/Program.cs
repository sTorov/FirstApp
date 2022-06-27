/*
 * Переменные и свойства, которые хранят состояние, общее для всех объектов класса, 
 * следует определять как статические.
 * 
 * Важно понимать, что статические методы могут обращаться только к статическим членам
 * класса и переданным им параметрам. Обращаться к нестатическим методам, полям или 
 * свойствам внутри них невозможно. Также, статический метод нельзя переопределить 
 * или объявить виртуальным.
 */

class Counter
{
    private static int increasingCounter;
    public static int IncreasingCounter
    {
        get
        {
            return increasingCounter;
        }
        set
        {
            if (value > increasingCounter)
            {
                increasingCounter = value;
            }
        }
    }
}

class Helper
{
    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Counter.IncreasingCounter++;
        Console.WriteLine(Counter.IncreasingCounter);

        int value = Helper.Sum(1, 2, 3);
    }
}