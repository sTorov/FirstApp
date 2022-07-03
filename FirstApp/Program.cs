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

            GetAmountOfElements();

            Console.ReadLine();
        }
        static void GetAmountOfElements()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\");
                if(dirInfo.Exists)
                    Console.WriteLine($"Папки: {dirInfo.GetDirectories().Length}\nФайлы: {dirInfo.GetFiles().Length}");
                
                DirectoryInfo newDir = new DirectoryInfo("C:\\DirCSharp");
                if (!newDir.Exists)
                    newDir.Create();
                
                Console.WriteLine($"\nПапки: {dirInfo.GetDirectories().Length}\nФайлы: {dirInfo.GetFiles().Length}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}