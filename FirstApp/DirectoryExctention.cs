using System.IO;

namespace DriverManager
{
    internal static class DirectoryExctention
    {
        public static long DirSize(DirectoryInfo dirInfo)
        {
            long size = 0;
            
            FileInfo[] files = dirInfo.GetFiles();
            foreach (var fl in files)
                size += fl.Length;

            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            foreach (var d in dirs)
                size += DirSize(d);

            return size;
        }
    }
}
