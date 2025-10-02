using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace InovanceH3U
{
    public static class Logger
    {
        private static readonly object _lock = new object();
        private static readonly string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
    //Theo ngày: mỗi ngày log file mới → log-YYYY-MM-DD.txt.

    //Theo level: dễ lọc trong file log.

    //Thread-safe: dùng lock để tránh khi nhiều thread cùng ghi log thì bị xung đột.

    //UTF-8: để log được cả tiếng Việt.
        static Logger()
        {
            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
        }

        private static string GetLogFile()
        {
            return Path.Combine(logDir, $"log-{DateTime.Now:yyyy-MM-dd}.txt");
        }

        public static void Write(string level, string message)
        {
            lock (_lock) // đảm bảo thread-safe
            {
                string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
                File.AppendAllText(GetLogFile(), logLine + Environment.NewLine, Encoding.UTF8);
            }
        }

        // Shortcut cho các level
        public static void Info(string message) => Write("INFO", message);
        public static void Error(string message) => Write("ERROR", message);
        public static void Debug(string message) => Write("DEBUG", message);

        // how to use ?
        // Khi connect PLC thành công
        // Logger.Info("PLC connected successfully.");

        //// Khi connect thất bại
        //Logger.Error("PLC connection failed.");

        //// Debug data
        //Logger.Debug("Read D100 value = 123");

        //Read log ?
        //string[] lines = File.ReadAllLines(logFile);
        //foreach (var line in lines)
        //{
        //    Console.WriteLine(line);
        //}

}
}
