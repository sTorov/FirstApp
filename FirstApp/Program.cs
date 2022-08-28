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

            if (!double.TryParse(str, out double result))
            {
                Console.WriteLine("Введено не верное зачение");
                Console.ReadKey();
                continue;
            }

            list.Add(result);
            Console.WriteLine("Число " + result + " добавлено в список");

            Console.WriteLine("\nИнформация о числовом ряде\n");
            Console.WriteLine($"{"Количество элементов", -33} {list.Count}");
            Console.WriteLine($"{"Сумма всех элементов", -33} {Math.Round(list.Sum(), 4)}");
            Console.WriteLine($"{"Наибольший элемент", -33} {list.Max()}");
            Console.WriteLine($"{"Наименьший элемент", -33} {list.Min()}");
            Console.WriteLine($"{"Среднее занчение всех элементов", -33} {Math.Round(list.Average(), 4)}");

            Console.ReadKey();
        }
    }    
}
