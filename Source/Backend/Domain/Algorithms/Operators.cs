using System;
using System.Linq;

namespace Domain.Algorithms
{
    public class Operators
    {
        /// <summary>
        /// Adds all integers.
        /// </summary>
        public static Func<int[], int> Add { get; }
            = input => input.Sum(i => i);

        /// <summary>
        /// Substracts all integeters.
        /// </summary>
        public static Func<int[], int> Subtract { get; }
            = input => Add(input) * -1;
    }
}