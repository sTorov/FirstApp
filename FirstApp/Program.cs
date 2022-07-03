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

            DeleteFolder();

            Console.ReadLine();
        }
        static void DeleteFolder()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo("C:\\CSharpDir");
                if(!dir.Exists)
                    dir.Create();

                dir.CreateSubdirectory("NewDir");

                dir.Delete(true);
                Console.WriteLine("Папка удалена");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}