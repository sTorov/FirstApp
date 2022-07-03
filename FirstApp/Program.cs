using System;
using System.IO;

namespace DriverManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\1357680\\Desktop\\CSarpDir");
            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory("Sub");
        }
    }
}