using System.Collections;
using System.Text;

class Program
{    
    public static Stack<string> words = new Stack<string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        //создадим очередь
        Queue<int> q = new Queue<int>();

        //добавим в неё целые числа от 0 до 10
        for (int i = 0; i <= 10; i++)
        {
            q.Enqueue(i);
            Console.WriteLine($"{i} зашёл в очередь");
        }

        //Посмотрим, кто первый в очереди
        Console.WriteLine($"\nПервый элемент: {q.Peek()}\n");
        //Обратите внимание, после вызова Peek() элемент остался в очереди

        //посмотрим всю очередь
        Console.WriteLine("Элементы в очереди");
        foreach (var item in q)
            Console.Write(item + " ");

        Console.WriteLine($"\nВ очереди {q.Count} элементов\n");

        //обработаем очередь
        //достанем из неё элементы один за другим
        int queueCount = q.Count;
        for(int i = 0; i < queueCount; i++)
            Console.WriteLine($"{q.Dequeue()} вышел из очереди");

        //посмотрим, сколько элементов осталось
        Console.WriteLine($"\nВ очереди {q.Count} элементов");
    }
}
