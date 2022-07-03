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

            Del();

            Console.ReadLine();
        }

        static void Del()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\1357680\Desktop\testFolder");
                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.MoveTo(@"C:\$Recycle.Bin\testFolder");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}