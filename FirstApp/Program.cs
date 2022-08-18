using System.Collections;
using System.Collections.Concurrent;
using System.Text;

class Program
{
    // объявим потокобезопасную очередь (полностью идентична обычной очереди, но
    // позволяет безопасный доступ
    // из разных потоков)
    public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;  

        Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
        Console.WriteLine();

        //  запустим обработку очереди в отдельном потоке
        StartQueueProcessing();

        while (true)
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "peek":
                    if(words.TryPeek(out string? result))
                        Console.WriteLine($"Крайний в очереди: {result}");
                    else
                        Console.WriteLine("Очередь пуста");
                    break;
                default:
                    words.Enqueue(input);
                    break;
            }
        }
    }

    // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
    // ( для выполнения задания изменять его не нужно )
    static void StartQueueProcessing()
    {
        new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;

            while (true)
            {
                Thread.Sleep(5000);
                if (words.TryDequeue(out var element))
                    Console.WriteLine("======>  " + element + " прошел очередь");
            }

        }).Start();
    }
}
