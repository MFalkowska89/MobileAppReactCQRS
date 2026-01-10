namespace SolutionReact.Server.Exceptions
{
    public class ValidationException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException()
            : base("Validation errors occured")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<FluentValidation.Results.ValidationFailure> failures)
            : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(
                    g => g.Key,
                    g => g.ToArray()
                );
        }

        public ValidationException(string propertyName, string errorMessage)
            : this()
        {
            Errors = new Dictionary<string, string[]>
            {
                { propertyName, new[] { errorMessage } }
            };
        }
    }
}