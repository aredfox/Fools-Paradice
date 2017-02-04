using System;
using System.Linq;

namespace Domain.Algorithms
{
    public class Operators
    {
        /// <summary>
        /// Adds all integers.
        /// </summary>
        public static Func<Die[], int> Add { get; }
            = input => input.Sum(die => die.Value);

        /// <summary>
        /// Substracts all integeters.
        /// </summary>
        public static Func<Die[], int> Subtract { get; }
            = input => Add(input) * -1;
    }
}