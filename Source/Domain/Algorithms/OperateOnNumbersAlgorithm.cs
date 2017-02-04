using System.Collections.Generic;
using System.Linq;

namespace Domain.Algorithms
{
    /// <summary>
    /// From a given set of dice it returns back the sum of the even numbers.
    /// </summary>
    public abstract class OperateOnNumbersAlgorithm : Algorithm<int>
    {
        public OperateOnNumbersAlgorithmOptions Options { get; }

        internal OperateOnNumbersAlgorithm(
            int min = 1,
            int max = 5,
            OperateOnNumbersAlgorithmOptions options = null)
            : base(min, max) {
            Options = options ?? OperateOnNumbersAlgorithmOptions.Default;
        }

        protected override AlgorithmResult<int> PerformAlgorithm(IEnumerable<Die> dice) {
            return new AlgorithmResult<int>(
                Options.Operator(
                    dice
                    .Where(die => Options.NumberSelector(die))
                    .ToArray()
                )
            );
        }
    }
}
