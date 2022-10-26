using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Console logger that has three log types.
    /// </summary>
    internal class Logger : ILogger
    {
        private static Logger? instance;
        private static StringBuilder? allRecordsOfTheSession;

        private Logger()
        {
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Logger"/> class.
        /// Writes all in theLog.txt file class.
        /// </summary>
        ~Logger()
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.Write(allRecordsOfTheSession!.ToString());
            }
        }

        /// <summary>
        /// Gets all records that was done during the session.
        /// </summary>
        /// <returns>All records of the session.</returns>
        public static string GetAllRecordsOfTheSession() => allRecordsOfTheSession!.ToString();

        /// <summary>
        /// Get logger sample(singleton).
        /// </summary>
        /// <returns>Singleton logger sample.</returns>
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
                allRecordsOfTheSession = new StringBuilder();
            }

            return instance;
        }

        /// <summary>
        /// Print in console logger info.
        /// </summary>
        /// <param name="result">Result of method execution.</param>
        /// <param name="logType">Enum that describes <see cref="LogType">.</param>.
        public void LogInfo(IResult result, LogType logType)
        {
            var currentLine = $"{DateTime.Now}:{logType}:{result.ErrorMessage}\n";
            Console.Write(currentLine);
            allRecordsOfTheSession!.Append(currentLine);
        }
    }
}
