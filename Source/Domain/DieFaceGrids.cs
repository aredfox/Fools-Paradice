using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// Defines the "Faces" for a <see cref="DieFace"/>.
    /// </summary>
    internal static class DieFaceGrids
    {
        public static IDictionary<int, bool[][]> Grids
            => new Dictionary<int, bool[][]> {
                { 1, One }, { 2, Two }, { 3, Three },
                { 4, Four }, { 5, Five }, { 6, Six }
            };

        public static bool[][] One
            => new bool[][] {
                    new bool[] {false, false, false},
                    new bool[] {false, true, false},
                    new bool[] {false, false, false}
            };

        public static bool[][] Two
            => new bool[][] {
                    new bool[] {true, false, false},
                    new bool[] {false, false, false},
                    new bool[] {false, false, true}
            };

        public static bool[][] Three
            => new bool[][] {
                    new bool[] {true, false, false},
                    new bool[] {false, true, false},
                    new bool[] {false, false, true}
            };

        public static bool[][] Four
            => new bool[][] {
                    new bool[] {true, false, true},
                    new bool[] {false, false, false},
                    new bool[] {true, false, true}
            };

        public static bool[][] Five
            => new bool[][] {
                    new bool[] {true, false, true},
                    new bool[] {false, true, false},
                    new bool[] {true, false, true}
            };

        public static bool[][] Six
            => new bool[][] {
                    new bool[] {true, true, true},
                    new bool[] {false, false, false},
                    new bool[] {true, true, true}
            };
    }
}
