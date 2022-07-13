namespace CheckNumber
{
    class Program
    {
        static void Main()
        {
            NumberReader reader = new NumberReader();
            reader.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    reader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено не корректное значение!");
                }
            }
        }
        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение 1");
                    break;
                case 2:
                    Console.WriteLine("Введено значение 2");
                    break;
            }
        }
    }

    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 или 2");
            int number = int.Parse(Console.ReadLine());
            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }
        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}