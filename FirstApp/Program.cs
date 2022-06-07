using System;

namespace Unit4
{
    class Logic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string Name = Console.ReadLine();
           
            Console.WriteLine("Ваше имя по буквам: ");

            foreach (char ch in Name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", Name[Name.Length - 1]);



            char[] cha = new char [Name.Length];

            Console.WriteLine("\n" + Name.Length + "\n");

            for (int i = 0; i < Name.Length; i++)
            {
                cha[i] = Name[i];
                Console.WriteLine(cha[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < Name.Length; i++)
            {
                char s = Name[i];
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}