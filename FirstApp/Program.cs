using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF7;
        Console.InputEncoding = System.Text.Encoding.UTF7;
        
        string tempFile = Path.GetTempFileName();   // используем генерацию имени файла.
        var fileInfo = new FileInfo(tempFile);      // Создаем объект класса FileInfo.

        //Создаем файл и записываем в него.
        using (StreamWriter sw = fileInfo.CreateText())
        {
            sw.WriteLine("Строка 1");
            sw.WriteLine("Строка 2");
            sw.WriteLine("Строка 3");
        }

        //Открываем файл и читаем из него.
        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }

        try
        {
            string tempFile2 = Path.GetTempFileName();  
            var fileInfo2 = new FileInfo(tempFile2);

            // Убедимся, что файл назначения точно отсутствует
            fileInfo2.Delete();

            // Копируем информацию
            fileInfo.CopyTo(tempFile2);
            Console.WriteLine($"{tempFile} скопирован в {tempFile2}");

            //Удаляем ранее созданный файл.
            fileInfo.Delete();
            Console.WriteLine($"{tempFile} удалён");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e}");
        }

        Console.ReadLine();
    }
}
