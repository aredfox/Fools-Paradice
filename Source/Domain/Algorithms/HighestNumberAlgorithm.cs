using System.Collections.Generic;
using System.Linq;

namespace Domain.Algorithms
{
    /// <summary>
    /// From a given set of dice it returns back the highest number.
    /// </summary>
    public class HighestNumberAlgorithm : Algorithm<int>
    {
        public HighestNumberAlgorithm(int min = 1, int max = 6) : base(min, max) { }

        protected override AlgorithmResult<int> PerformAlgorithm(IEnumerable<Die> dice) {
            return new AlgorithmResult<int>(dice.Max(die => die.Value));
        }
    }
}
