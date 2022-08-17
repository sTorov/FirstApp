using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        //создадим числовой стек
        Stack<int> numbers = new Stack<int>();

        numbers.Push(3); // в стеке 3
        numbers.Push(5); // в стеке 5, 3
        numbers.Push(8); // в стеке 8, 5, 3

        Console.WriteLine("Элементы числового стека:");
        foreach (var item in numbers)
            Console.WriteLine(item);

        Console.WriteLine($"Извлекаем верхний элемент из стека: {numbers.Pop()}");
        // в стеке остались 5, 3

        Console.WriteLine();
        
        //создадим стек объектов
        Stack<Person> people = new Stack<Person>();
        people.Push(new Person { Name = "Dima" });
        people.Push(new Person { Name = "Sergey" });
        people.Push(new Person { Name = "Anna" });

        Console.WriteLine("Элементы стека объектов:");
        foreach(var item in people)
            Console.WriteLine(item.Name);

        Console.WriteLine($"Извлекаем верхний элеменгт из стека объектов: {people.Pop().Name}");

    }

    class Person
    {
        public string Name { get; set; }
    }
}
