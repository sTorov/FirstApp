class Program
{
    static void Main()
    {
        int count;

        while (true)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");

            try
            {
                count = int.Parse(Console.ReadLine());
                if (count <= 0)
                    throw new Exception("Введённое значение должно быть больше 0!");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
            }
        }

        string[] array = new string[count];
        for (int i = 0; i < count; i++)
            array[i] = Console.ReadLine();

        Console.WriteLine("Все элементы записаны");
    }
}