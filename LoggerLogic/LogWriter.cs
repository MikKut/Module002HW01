using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Writes logs.
    /// </summary>
    public static class LogWriter
    {
        private static readonly string PathOfTheFile = $"{Directory.GetCurrentDirectory()}\\log.txt";

        /// <summary>
        /// Writes all records in file from current directory.
        /// </summary>
        public static void WriteAllInFile()
        {
            File.WriteAllText(PathOfTheFile, Logger.GetAllLogs());
            Console.WriteLine($"The records were written in file {PathOfTheFile}");
        }
    }
}
