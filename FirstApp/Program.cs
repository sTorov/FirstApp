public class Folder
{
    public Folder(string name)
    {
        Name = name;
    }

    string Name { get; set; }
    List<string> Files { get; set; } = new List<string>();

    public void AddFile(string name)
    {
        if (!Files.Contains(name))
            Files.Add(name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Folder folder = new Folder("Папка");
        folder.AddFile("Новый файл");

        Console.ReadLine();
    }
}