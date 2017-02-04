using System;

namespace Domain.Algorithms
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
        public Func<Die, bool> NumberSelector { get; } =
            i => true;


        /// <summary>
        /// The operator function, defaults to <see cref="Operators.Add"/>.
        /// </summary>
        public Func<Die[], int> Operator { get; }
            = Operators.Add;

        /// <summary>
        /// Create a new options object.
        /// </summary>
        public OperateOnNumbersAlgorithmOptions(
            Func<Die, bool> numberSelectorFunction = null,
            Func<Die[], int> operatorFunction = null) {
            if (numberSelectorFunction != null) {
                NumberSelector = numberSelectorFunction;
            }
            if (operatorFunction != null) {
                Operator = operatorFunction;
            }
        }
    }
}