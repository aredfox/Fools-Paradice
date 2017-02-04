using System.Linq;

namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    public class AddNumbersWithCenterDotAlgorithm : OperateOnNumbersAlgorithm
    {
        public AddNumbersWithCenterDotAlgorithm(int min = 1, int max = 5) : base(
            min: min,
            max: max,
            options: new OperateOnNumbersAlgorithmOptions(
                numberSelectorFunction: die => {
                    var dieFace = DieFaceGrids.Grids.Single(g => g.Key == die.Value).Value;
                    return dieFace[1][1];
                },
                operatorFunction: Operators.Add
            )
        ) { }
    }
}
