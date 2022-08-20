using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        var names = (from p in people
                    where p.ToUpper().StartsWith("А")
                    orderby p
                    select p).Count();

        Console.WriteLine($"В выборке {names} чел");
    }
}
