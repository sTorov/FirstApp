using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        var companies = new Dictionary<string, string[]>();

        companies.Add("Apple", new[] { "Mobile", "Desktop" });
        companies.Add("Samsung", new[] { "Mobile" });
        companies.Add("IBM", new[] { "Desktop" });

        var select = from i in companies
                     where i.Value.Contains("Mobile")
                     select i;

        foreach(var i in select)
            Console.WriteLine(i.Key);
        Console.WriteLine();

        var select2 = companies
            .Where(c => c.Value.Contains("Mobile"));

        foreach(var i in select2)
            Console.WriteLine(i.Key);
    }
}
