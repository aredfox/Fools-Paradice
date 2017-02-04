namespace Domain.Algorithms
{
    public class AlgorithmResult<T>
    {
        /// <summary>
        /// The algorithm's output.
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// Whether the result was an error.
        /// </summary>
        public bool HasError { get; }

        /// <summary>
        /// The error message.
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// Creates a new <see cref="AlgorithmErrorResult{T}"/>.
        /// </summary>
        /// <param name="value">The value/output of the algorithm.</param>
        /// <param name="hasError">Whether an error occured or not.</param>
        /// <param name="errorMessage">The error message attached when an error has occured.</param>
        internal AlgorithmResult(T value, bool hasError = false, string errorMessage = "") {
            Value = value;
            HasError = hasError;
            ErrorMessage = errorMessage;
        }
    }
}