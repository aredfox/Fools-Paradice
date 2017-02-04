namespace Domain.Algorithms
{
    internal class AlgorithmErrorResult<T> : AlgorithmResult<T>
    {
        internal AlgorithmErrorResult(string errorMessage)
            : base(default(T), true, errorMessage) { }
    }
}