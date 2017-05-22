using Drinker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerApp
{
    public static class Logger
    {
        private static string pattern;

        static Logger()
        {
            string fileIni = "logger.ini";

            pattern = "[Player] [Func] [Type] [Message]";
            if (File.Exists(fileIni))
            {
                var lines = File.ReadAllLines(fileIni);
                if (lines.Length != 0)
                    pattern = lines[0];
            }
        }

        /// <summary>
        /// Метод записывающий информацию о ходе выполнения приложения формата *.txt
        /// </summary>
        /// <param name="player">имя игрока или имя пользователя запустившего приложение</param>
        /// <param name="funk">имя функции, из которой добавляется запись в файл</param>
        /// <param name="type">тип выполнения (см. Enum TypeAction)</param>
        /// <param name="message">доп.информация</param>
        public static void Write(string player, string funk, TypeAction type, string message)
        {
            DateTime date = DateTime.Now;
            StringBuilder strBuilder = new StringBuilder(pattern);
            strBuilder.Replace("[Player]", player);
            strBuilder.Replace("[Func]", funk);
            strBuilder.Replace("[Type]", type.ToString());  
            strBuilder.Replace("[Message]", message);
            strBuilder.Append(Environment.NewLine);
            string dirApp = Environment.CurrentDirectory;

            if (!Directory.Exists(Path.Combine(dirApp, "Logs")))
                Directory.CreateDirectory(Path.Combine(dirApp, "Logs"));

            string fileName = String.Format("{2}-{1:00}-{0:00}.txt", date.Day,
                                                                 date.Month,
                                                                 date.Year);
            string filePath = Path.Combine(dirApp, "Logs", fileName);

            File.AppendAllText(filePath, strBuilder.ToString());
        }        
    }
}
