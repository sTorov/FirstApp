using System;
using System.IO;
class FileWriter
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF7;
        Console.InputEncoding = System.Text.Encoding.UTF7;

        string FileName = @"C:\Users\1357680\Desktop\BinaryFile.bin";

        ReadValues(FileName);
    }

    static void ReadValues(string path)
    {
        string StringValues;

        if(File.Exists(path))
        {
            using(BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                StringValues = reader.ReadString();
            }

            Console.WriteLine("Из файла считано:");

            Console.WriteLine("Строка " + StringValues);
        }
    }
}
