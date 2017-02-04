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
        /// Can be used to determine which die to select.
        /// </summary>
        public Func<Die, bool> NumberSelector { get; } =
            die => true;

        /// <summary>
        /// Number transformer function, default to return the value of the die.
        /// Can be used to transform the die's Value based on the die's properties.
        /// </summary>
        public Func<Die, int> NumberTransformer { get; } =
            die => die.Value;

        /// <summary>
        /// The operator function, defaults to <see cref="Operators.Add"/>.
        /// </summary>
        public Func<int[], int> Operator { get; }
            = Operators.Add;

        /// <summary>
        /// Create a new options object.
        /// </summary>
        public OperateOnNumbersAlgorithmOptions(
            Func<Die, bool> numberSelectorFunction = null,
            Func<Die, int> numberTransformerFunction = null,
            Func<int[], int> operatorFunction = null) {
            if (numberSelectorFunction != null) {
                NumberSelector = numberSelectorFunction;
            }
            if (numberTransformerFunction != null) {
                NumberTransformer = numberTransformerFunction;
            }
            if (operatorFunction != null) {
                Operator = operatorFunction;
            }
        }
    }
}