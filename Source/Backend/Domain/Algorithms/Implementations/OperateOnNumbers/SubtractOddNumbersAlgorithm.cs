namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    public class SubtractOddNumbersAlgorithm : OperateOnNumbersAlgorithm
    {
        public SubtractOddNumbersAlgorithm(int min = 1, int max = 5) : base(
            min: min,
            max: max,
            options: new OperateOnNumbersAlgorithmOptions(
                numberSelectorFunction: die => die.Value % 2 != 0,
                operatorFunction: Operators.Subtract
            )
        ) { }
    }
}
