using System;
using System.IO;
using System.Linq;

namespace DriverManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF7;
            Console.InputEncoding = System.Text.Encoding.UTF7;

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives.Where(drive => drive.DriveType == DriveType.Fixed))
            {
                WriteDriveInfo(drive);

                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();

                WriteFilesInfo(root);
                WriteFoldersInfo(folders);

            }

            Console.ReadLine();
        }

        static void WriteDriveInfo(DriveInfo drive)
        {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Объём: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
            Console.WriteLine();
        }
        static void WriteFoldersInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine("\nПапки:\n");
            foreach (var folder in folders)
            {
                try
                {
                    Console.WriteLine(folder.Name + $" - {DirectoryExctention.DirSize(folder)} байт");
                }
                catch (Exception e)
                {
                    Console.WriteLine(folder.Name + $" - Не удалось расчитать размер: {e.Message}");
                }                
            }
            Console.WriteLine();
        }

        static void WriteFilesInfo(DirectoryInfo rootFolder)
        {
            Console.WriteLine("\nФайлы:\n");
            foreach (var file in rootFolder.GetFiles())
            {
                Console.WriteLine(file.Name + $" - {file.Length} байт");
            }
        }
    }
}