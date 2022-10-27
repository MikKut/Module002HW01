using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Represents result of a method simulation.
    /// </summary>
    internal class Result : IResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="errorMessage">Adds an error message <see cref="IResult.ErrorMessage">.</param>.
        /// <param name="status">Describes posibility of program continuation <see cref="IResult.Status">.</param>.
        public Result(string errorMessage, bool status)
        {
            this.ErrorMessage = errorMessage;
            this.Status = status;
        }

        /// <inheritdoc/>
        public string ErrorMessage { get; private set; }

        /// <inheritdoc/>
        public bool Status { get; private set; }
    }
}
