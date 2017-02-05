using System.Collections.Generic;
using System.Linq;

namespace Domain.Dice
{
    public static class DiceSets
    {
        public static Die[] OneTwoThreeFourFive
            => Create(1, 2, 3, 4, 5).ToArray();

        public static IEnumerable<Die> Create(int die1, int die2, int die3, int die4, int die5)
            => CreateFrom(die1, die2, die3, die4, die5);
        public static IEnumerable<Die> CreateFrom(params int[] values) {
            foreach (var i in values) {
                yield return new Die(i);
            }
        }
    }
}
