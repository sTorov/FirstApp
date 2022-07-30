using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Extensions
{
    public static class DirectoryExtensions
    {
        /// <summary>
        /// Получаем путь до каталога с sln. файлом
        /// </summary>
        /// <returns></returns>
        public static string GetSolutionRoot()
        {
            var dir = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var fullname = Directory.GetParent(dir).FullName;
            var project = fullname.Substring(0, fullname.Length - 4);
            return Directory.GetParent(project)?.FullName;
        }
    }
}
