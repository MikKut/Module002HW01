using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    /// <summary>
    /// Fakes some work.
    /// </summary>
    internal interface IAction
    {
        /// <summary>
        /// Represents normal work.
        /// </summary>
        /// <returns>Normal result.</returns>
        public IResult MethodGoesInNormalWay();

        /// <summary>
        /// Represents work with warnings.
        /// </summary>
        /// <returns>Uncorrect result.</returns>
        public IResult MethodGoesWithWarnings();

        /// <summary>
        /// Represents work with errors.
        /// </summary>
        /// <returns>Uncorrect result.</returns>
        public IResult MethodGoesWithErrors();
    }
}
