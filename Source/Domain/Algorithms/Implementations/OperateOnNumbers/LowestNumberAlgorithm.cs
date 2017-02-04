using System.Linq;

namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    /// <summary>
    /// From a given set of dice it returns back the highest number.
    /// </summary>
    public class LowestNumberAlgorithm : OperateOnNumbersAlgorithm
    {
        public LowestNumberAlgorithm(int min = 1, int max = 5) : base(
            min: min,
            max: max,
            options: new OperateOnNumbersAlgorithmOptions(
                operatorFunction: input => input.Min(die => die.Value)
            )
        ) { }
    }
}