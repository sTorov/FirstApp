using System.Collections;
using System.Collections.Concurrent;
using System.Text;

class Program
{
    //Объявим список в виде статической переменной
    public static LinkedList<string> strings = new LinkedList<string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;
        
        //добавим несколько элементов
        strings.AddFirst("Лиса");
        strings.AddFirst("Волк");
        strings.AddFirst("Заяц");
        var mouse = strings.AddFirst("Мышь");

        GoOnwards();    //прямой проход списка
        GoBackwards();  //обратный проход списка

        //вставка нового элемента
        strings.AddAfter(mouse, "Медведь");
        
        Console.WriteLine("\n\nВыведем список ещё раз после вставки\n");

        GoOnwards();    //прямой проход списка
        GoBackwards();  //обратный проход списка
    }

    static void GoOnwards()
    {
        LinkedListNode<string> node;

        Console.WriteLine("Элементы коллекции в прямом направлении:");
        for(node = strings.First; node != null; node = node.Next)
            Console.Write(node.Value + " ");
    }

    static void GoBackwards()
    {
        LinkedListNode<string> node;

        Console.WriteLine("\n\nЭлементы коллекции в обратном направлении:");
        for (node = strings.Last; node != null; node = node.Previous)
            Console.Write(node.Value + " ");
    }
}
