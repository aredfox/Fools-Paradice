using Kf.Core.Randomization;
using System;
using System.Linq;

namespace Domain
{
    /// <summary>
    /// Represents a die.
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Gets a random number between 1 and 6.
        /// </summary>
        /// <returns>An <see cref="int"/> between 1 and 6.</returns>
        private static int RollRandom() {
            return StaticRandom.Next(1, 6);
        }

        /// <summary>
        /// Creates a <see cref="Die"/> with a random value.
        /// </summary>
        public Die()
            : this(StaticRandom.Next(1, 6)) { }
        /// <summary>
        /// Creates a die with a specific value.
        /// </summary>        
        /// <param name="value">The value of the die (needs to be between 1 and 6).</param>
        public Die(int value) {
            if (!Enumerable.Range(1, 6).Any(v => v == value)) {
                throw new ArgumentOutOfRangeException(nameof(value), $"Value given was {value}, but must be between 1 and 6.");
            }
            Value = value;
        }

        /// <summary>
        /// Gets the value of the die.
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        public void Roll() {
            Value = RollRandom();
        }

    }
}
