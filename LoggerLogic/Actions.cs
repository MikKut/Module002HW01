using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Simulates work.
    /// </summary>
    internal class Actions : IAction
    {
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Actions"/> class.
        /// </summary>
        public Actions()
        {
            this.logger = Logger.GetLogger();
        }

        /// <inheritdoc/>
        public IResult MethodGoesInNormalWay()
        {
            var result = new Result("Goes in a normal way", true);
            Console.Write($"Start method: {nameof(this.MethodGoesInNormalWay)}");
            this.logger.LogInfo(result, LogType.Information);
            return result;
        }

        /// <inheritdoc/>
        public IResult MethodGoesWithErrors()
        {
            var result = new Result("STOPPED because of the exception", false);
            Console.Write($"I broke a logic: {nameof(this.MethodGoesWithErrors)}");
            this.logger.LogInfo(result, LogType.Error);
            return result;
        }

        /// <inheritdoc/>
        public IResult MethodGoesWithWarnings()
        {
            var result = new Result("Goes with warnings", true);
            Console.Write($"Skipped logic in method: {nameof(this.MethodGoesWithWarnings)}");
            this.logger.LogInfo(result, LogType.Error);
            return result;
        }
    }
}
