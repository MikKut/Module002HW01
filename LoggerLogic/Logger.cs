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
        /// Gets all logs of the current session.
        /// </summary>
        /// <returns>String that represents all records of the session.</returns>
        public static string GetAllLogs()
        {
            return allRecordsOfTheSession == null ? string.Empty : allRecordsOfTheSession.ToString();
        }

        /// <summary>
        /// Get logger sample(singleton).
        /// </summary>
        /// <returns>Singleton logger sample.</returns>
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
                allRecordsOfTheSession = new StringBuilder(string.Empty);
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
