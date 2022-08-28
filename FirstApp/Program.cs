using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        List<double> list = new List<double>();

        while (true)
        {
            Console.Clear();

            Console.Write("Введите число: ");
            string str = Console.ReadLine();

            switch (str)
            {
                case "exit":
                    return;
                case "reset":
                    list.Clear();
                    Console.WriteLine("Список очищен");
                    Console.ReadKey();
                    continue;
                case "info":
                    CheckList(list, l => Handler(l), "Список пуст");
                    continue;
                case "view":
                    CheckList(list, l => string.Join("\n", l), "Список пуст");
                    continue;
            }


            if (!double.TryParse(str, out double result))
            {
                Console.WriteLine("Введено не верное зачение");
                Console.ReadKey();
                continue;
            }

            list.Add(result);
            Console.WriteLine("Число " + result + " добавлено в список");

            Handler(list);

            Console.ReadKey();
        }       

    }

    static void Handler(List<double> list)
    {
        Console.WriteLine("\nИнформация о числовом ряде\n");
        Console.WriteLine($"{"Количество элементов",-33} {list.Count}");
        Console.WriteLine($"{"Сумма всех элементов",-33} {Math.Round(list.Sum(), 4)}");
        Console.WriteLine($"{"Наибольший элемент",-33} {list.Max()}");
        Console.WriteLine($"{"Наименьший элемент",-33} {list.Min()}");
        Console.WriteLine($"{"Среднее занчение всех элементов",-33} {Math.Round(list.Average(), 4)}");
    }

    static void CheckList<T>(T list, Action<T> action, string text) where T : List<double>
    {
        if (list != null && list.Count > 0)
        {
            action(list);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }

    static void CheckList<T, TResult>(T list, Func<T, TResult> func, string text) where T : List<double>
    {
        if (list != null && list.Count > 0)
        {
            Console.WriteLine(func(list));
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
