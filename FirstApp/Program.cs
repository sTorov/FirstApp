using System;
using System.IO;

namespace DriverManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;
            Console.InputEncoding = System.Text.Encoding.UTF7;

            GetCatalogs();

            Console.ReadLine();
        }
        static void GetCatalogs()
        {
            string dirName = "C:\\";
            if (Directory.Exists(dirName))  //Проверяем наличие папки
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  //Получаем все папки корневого каталога

                foreach (var dir in dirs)   //Выведим их все в консоль
                    Console.WriteLine(dir);

                Console.WriteLine();

                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName); //Получим все файлы корневого каталога

                foreach (var file in files)
                    Console.WriteLine(file);                
            }
        }
    }
}