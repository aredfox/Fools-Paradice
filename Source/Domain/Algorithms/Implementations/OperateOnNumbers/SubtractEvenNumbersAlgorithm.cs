namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    public class SubtractEvenNumbersAlgorithm : OperateOnNumbersAlgorithm
    {
        public SubtractEvenNumbersAlgorithm(int min = 1, int max = 5) : base(
            min: min,
            max: max,
            options: new OperateOnNumbersAlgorithmOptions(
                numberSelectorFunction: i => i % 2 == 0,
                operatorFunction: Operators.Subtract
            )
        ) { }
    }
}
