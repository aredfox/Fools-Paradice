using Kf.Core.Range;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Algorithms
{
    /// <summary>
    /// Defines an algorithm for a given set of dice.
    /// </summary>
    /// <typeparam name="T">The type of output the algorithm produces.</typeparam>
    public abstract class Algorithm<T>
    {
        /// <summary>
        /// The min & max number of dice.
        /// </summary>
        IRange<int> DiceRange { get; }

        /// <summary>
        /// Creates a new <see cref="Algorithm{T}"/> based.
        /// </summary>
        /// <param name="min">Minimum dice the <see cref="Execute(IEnumerable{Die})"/> method can take.</param>
        /// <param name="max">Maximum dice the <see cref="Execute(IEnumerable{Die})"/> method can take.</param>
        /// <exception cref="ArgumentOutOfRangeException">When <paramref name="min"/> is lower than 1.</exception>
        public Algorithm(int min = 1, int max = 5) {
            if (min <= 0) {
                throw new ArgumentOutOfRangeException(nameof(min), $"Parameter {nameof(min)} needs to be at least 1 or higher.");
            }
            DiceRange = new Int32Range(min, max);
        }

        /// <summary>
        /// Execute the algorithm and produces a given output based upon the given input of dice.
        /// </summary>        
        public AlgorithmResult<T> Execute(IEnumerable<Die> dice) {
            var canExecute = CanExecute(dice);
            if (canExecute.Item1) {
                return PerformAlgorithm(dice);
            }
            else {
                return new AlgorithmErrorResult<T>(canExecute.Item2);
            }
        }

        /// <summary>
        /// Execute the algorithm and return the result.
        /// </summary>        
        protected abstract AlgorithmResult<T> PerformAlgorithm(IEnumerable<Die> dice);

        /// <summary>
        /// Determines whether the method is able to execute.
        /// Default check(s) that happen are whether the input is in range.
        /// </summary>
        /// <param name="dice">The input of dice</param>
        /// <returns>A <see cref="Tuple{bool, string}"/>, where the <see cref="bool"/> returns whether execution can go on, and the <see cref="string"/> is an error message.</returns>
        protected virtual Tuple<bool, string> CanExecute(IEnumerable<Die> dice) {
            if (dice == null) {
                return new Tuple<bool, string>(false, $"Amount of dice is 0, expected to be between {DiceRange.Minimum} and {DiceRange.Maximum}.");
            }
            if (DiceRange.IsInRange(dice.Count())) {
                return new Tuple<bool, string>(true, "");
            }
            else {
                return new Tuple<bool, string>(false, $"Amount of dice is {dice.Count()}, expected to be between {DiceRange.Minimum} and {DiceRange.Maximum}.");
            }
        }
    }
}
