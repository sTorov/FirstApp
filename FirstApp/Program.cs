class Program
{
    static void Main()
    {
        Console.WriteLine("Как Вас зовут?");
        string name = Console.ReadLine();
        string greetings = "Привет, " + name;
        Console.WriteLine(greetings);
    }
}