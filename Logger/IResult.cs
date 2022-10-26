namespace Logger
{
    /// <summary>
    /// Represents a result of the method execution for logging.
    /// </summary>
    internal interface IResult
    {
        /// <summary>
        /// Gets a value indicating whether the program can continue working or not.
        /// </summary>
        public bool Status { get; }

        /// <summary>
        /// Gets a message result of the method execution for logging.
        /// </summary>
        public string ErrorMessage { get; }
    }
}