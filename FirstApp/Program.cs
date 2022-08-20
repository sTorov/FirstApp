using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF7;
        Console.InputEncoding = Encoding.Unicode;

        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        var names = from p in people // промежуточная переменная p
                    where p.StartsWith("А") // фильтрация по условию
                    orderby p // сортировка по возрастанию (дефолтная)
                    select p; // выбираем объект и сохраняем в выборку

        foreach(string name in names)
            Console.WriteLine(name);
    }
}
