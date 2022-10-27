using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Types of log message: Error, Info, Warning.
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// Critical crash that the program will not miss.
        /// </summary>
        Error,

        /// <summary>
        /// An unwanted malfunction that the program will miss.
        /// </summary>
        Warning,

        /// <summary>
        /// Sign of a normal program execution.
        /// </summary>
        Information,
    }
}
