using System.Collections.Generic;
using System.Linq;

namespace Domain.Algorithms
{
    /// <summary>
    /// From a given set of dice it returns back the highest number.
    /// </summary>
    public class HighestNumberAlgorithm : Algorithm<int>
    {
        protected override AlgorithmResult<int> PerformAlgorithm(IEnumerable<Die> dice) {
            return new AlgorithmResult<int>(dice.Max(die => die.Value));
        }
    }
}
