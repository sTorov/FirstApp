using System.Collections;
using System.Text;

class Program
{    
    public static Stack<string> words = new Stack<string>();

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Введите слово или комманду: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "pop":
                    if (words.TryPop(out string? pop))
                        Console.WriteLine("Последний элемент извлечен");
                    else
                        Console.WriteLine("Стек пуст");
                    break;
                case "peek":
                    if (words.TryPeek(out string? peek))
                        Console.Write($"Последний элемент в стеке: {peek}\n");
                    else
                        Console.WriteLine("Стек пуст");
                    break;
                default:
                    words.Push(input);
                    break;
            }

            Console.WriteLine("\nВ стеке:");

            foreach (var word in words)
                Console.WriteLine(" " + word);

            Console.WriteLine();
        }
    }
}
