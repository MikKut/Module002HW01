namespace Logger
{
    /// <summary>
    /// Logs information in console.
    /// </summary>
    internal interface ILogger
    {
        /// <summary>
        /// Logs information considering result <see cref="IResult"> and logtype <see cref="LogType">.
        /// </summary>
        /// <param name="result">Describes <see cref="IResult">.</param>
        /// <param name="logType">Describes <see cref="LogType">.</param>
        void LogInfo(IResult result, LogType logType);
    }
}