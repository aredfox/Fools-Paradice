using System.Linq;

namespace Domain.Algorithms.Implementations.OperateOnNumbers
{
    public class AddNumbersAroundCenterDotAlgorithm : OperateOnNumbersAlgorithm
    {
        public AddNumbersAroundCenterDotAlgorithm(int min = 1, int max = 5) : base(
            min: min,
            max: max,
            options: new OperateOnNumbersAlgorithmOptions(
                numberSelectorFunction: die => {
                    var dieFace = DieFaceGrids.Grids.Single(g => g.Key == die.Value).Value;
                    if (dieFace[1][1]) { // check for center dot
                        for (var rows = 0; rows < dieFace.Length; rows++) {
                            for (var cols = 0; cols < dieFace[rows].Length; cols++) {
                                if (!(rows == 1 & cols == 1)) { // ignore center dot
                                    if (dieFace[rows][cols]) { // as soon as we have found at least one neighbout we exit
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    return false; // no neighbours were found
                },
                numberTransformerFunction: die => {
                    // one middle dot, 
                    // meaning we have to get the value of the die's face minus the center dot
                    return die.Value - 1;
                },
                operatorFunction: Operators.Add
            )
        ) { }
    }
}
