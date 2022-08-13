class Program
{
    static void Main()
    {
        string path = @"D:\cdev_Text.txt";

        char[] ch = { ' ', '\n' };

        string[] str = File.ReadAllText(path).Split(ch, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(str.Length);
    }
}