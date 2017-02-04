using Domain.Algorithms;
using Kf.Core.Randomization;
using System;
using System.Linq;
using System.Reflection;

namespace Domain
{
    public class NumberGame : Game<int>
    {
        /// <summary>
        /// Creates a new number game.
        /// </summary>
        public NumberGame()
            : base() { }

        /// <summary>
        /// Selects an algorithm at random from the bool of Domain.Algorithms.Implementations
        /// </summary>
        /// <returns>An algorithm.</returns>
        protected internal override Algorithm<int> SelectAlgorithm() {
            var algorithmsToChooseFrom = Assembly.GetAssembly(typeof(Algorithm<>))
                .GetTypes()
                .Where(t => typeof(Algorithm<int>).IsAssignableFrom(t))
                .Where(t => !t.IsAbstract && !t.IsInterface)
                .Where(t => t.Namespace.StartsWith("Domain.Algorithms.Implementations")) // optional - but I want to restrict to searching here
                .Where(t => t.Name.EndsWith("Algorithm")) // optinal - but I want to enforce this naming convention                
                .ToList();

            var algorithmType = algorithmsToChooseFrom[StaticRandom.Next(algorithmsToChooseFrom.Count - 1)];
            var algorithmInstance = Activator.CreateInstance(algorithmType, 1, 5) as Algorithm<int>;

            return algorithmInstance;
        }
    }
}
