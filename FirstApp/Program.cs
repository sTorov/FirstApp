using System.Collections;

class Program
{
    static void Main()
    {
        var months = new[]
        {
           "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        var numbers = new[]
        {
            1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
        };

        var list = new ArrayList();

        foreach (var number in numbers)
        {
            // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
            list.Add(months[number - 1]);

            // добавляем его порядковый номер
            list.Add(number);
        }

        foreach (var item in list)
            Console.WriteLine(item);
    }
}