using System;

namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    public class OperateOnNumbersAlgorithmOptions
    {
        /// <summary>
        /// Default <see cref="OperateOnNumbersAlgorithmOptions"/> object.
        /// </summary>
        internal static OperateOnNumbersAlgorithmOptions Default { get; }
            = new OperateOnNumbersAlgorithmOptions();

        /// <summary>
        /// Number selector function, defaults to returning all numbers.
        /// </summary>
        public Func<int, bool> NumberSelector { get; } =
            i => true;


        /// <summary>
        /// The operator function, defaults to <see cref="Operators.Add"/>.
        /// </summary>
        public Func<int[], int> Operator { get; }
            = Operators.Add;

        /// <summary>
        /// Create a new options object.
        /// </summary>
        public OperateOnNumbersAlgorithmOptions(
            Func<int, bool> numberSelectorFunction = null,
            Func<int[], int> operatorFunction = null) {
            if (numberSelectorFunction != null) {
                NumberSelector = numberSelectorFunction;
            }
            if (operatorFunction != null) {
                Operator = operatorFunction;
            }
        }
    }
}