using System;
using System.Linq;

namespace Domain
{
    public class DieFace
    {
        /// <summary>
        /// Creates a new <see cref="DieFace"/>.
        /// </summary>
        /// <param name="face">The physical representation of the face.</param>
        /// <exception cref="ArgumentNullException">When face is null.</exception>
        internal DieFace(bool[][] grid) {
            if (grid == null) throw new ArgumentNullException(nameof(grid));
            Grid = grid;
            Value = Grid.Sum(row => row.Count(value => value));
        }

        /// <summary>
        /// Represents the value of the face.
        /// </summary>
        public int Value { get; }
        /// <summary>
        /// Physical representation of the dots on the face of the die.
        /// </summary>
        public bool[][] Grid { get; }
    }
}
