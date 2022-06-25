/*
 * Сигнатура метода — это уникальный набор информации о методе, состоящий из его имени, количества, 
 * типа и порядка параметров а также из модификаторов параметров. 
 */
class Program
{
    //Сигнатура Greetings(string)
    void Greetings(string name)
    {
        Console.WriteLine("Привет, {0}", name);
    }

    /*
     * Поскольку сигнатура не включает в себя тип возвращаемого значения и наименования 
     * аргументов, данные методы будут иметь одинаковую сигнатуру Greetings(string, string)
     */
    void Greetings(string name, string surname)
    {
        Console.WriteLine($"Рад снова Вас видеть, {surname} {name}");
    }

    string Greetings(string name, string surname)
    {
        return $"Приветствую, {surname} {name}";
    }

    string Greetings(string firstUser, string secondUser)
    {
        return $"Добро пожаловать, {firstUser} и {secondUser}";
    }

    /*
     * Перегрузка метода — это возможность использования разных методов с одинаковым названием, но отличными друг от друга сигнатурами.        * 
     */
    long Sum(long a, long b)
    {
        return a + b;
    }

    double Sum(double a, double b)
    {
        return a + b;
    }

    int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static void Main(string[] args)
    {
        
    }
}