using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        var months = new List<string>()
        {
           "Jan", "Feb", "Mar", "Apr", "May"
        };

        var missing = new ArrayList()
        {
           1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        GetMissing(months, missing);
    }

    private static void GetMissing(List<string> months, ArrayList missing)
    {
        // инициализируем массив для 7 нужных нам недостающих элементов
        var missedArray = new string[7];

        // извлекаем эти элементы из ArrayList, и копируем в массив
        missing.GetRange(4, 7).CopyTo(missedArray);

        // Добавляем наш массив в конец списка
        months.AddRange(missedArray);

        // смотрим, что получилось
        foreach (var month in months)
            Console.WriteLine(month);
    }
}