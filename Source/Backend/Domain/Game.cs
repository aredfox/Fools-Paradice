using Domain.Algorithms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain
{
    /// <summary>
    /// Represents a single game.
    /// </summary>
    public abstract class Game<T>
    {
        /// <summary>
        /// The algorithm currently being used.
        /// </summary>
        public Algorithm<T> Algorithm { get; }

        /// <summary>
        /// Keeps tracks of your rounds and the given results by the algorithm.
        /// </summary>
        public IReadOnlyCollection<Tuple<AlgorithmResult<T>, IEnumerable<Die>>> Rounds =>
            new ReadOnlyCollection<Tuple<AlgorithmResult<T>, IEnumerable<Die>>>(_rounds);
        private readonly IList<Tuple<AlgorithmResult<T>, IEnumerable<Die>>> _rounds;

        /// <summary>
        /// Creates a new game.
        /// </summary>
        internal Game() {
            Algorithm = SelectAlgorithm();
            _rounds = new List<Tuple<AlgorithmResult<T>, IEnumerable<Die>>>();
        }

        /// <summary>
        /// Processes your input and 
        /// </summary>
        /// <param name="dice"></param>
        /// <returns></returns>
        public AlgorithmResult<T> Round(IEnumerable<Die> dice = null) {
            var result = Algorithm.Execute(dice);
            SaveRound(result, dice);
            return result;
        }

        /// <summary>
        /// Selects an algorithm.
        /// </summary>
        /// <returns>An algorithm.</returns>
        protected internal abstract Algorithm<T> SelectAlgorithm();

        /// <summary>
        /// Saves the round.
        /// </summary>
        /// <param name="result">The result given by the algorithm.</param>
        /// <param name="input">The input by the user.</param>
        private void SaveRound(AlgorithmResult<T> result, IEnumerable<Die> input) {
            _rounds.Add(new Tuple<AlgorithmResult<T>, IEnumerable<Die>>(result, input));
        }
    }
}
