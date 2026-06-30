using System.Collections.Generic;
using System.Linq;

namespace MedAvail.Utilities
{
    public sealed class ValidationResult
    {
        private readonly List<string> _errors;

        private ValidationResult(List<string> errors)
        {
            _errors = errors;
        }

        public bool IsValid => _errors.Count == 0;
        public IReadOnlyList<string> Errors => _errors;

        public string Summary =>
            IsValid ? "Valid" : string.Join("; ", _errors);

        public static ValidationResult Valid() => new ValidationResult(new List<string>());

        public static ValidationResult Invalid(string error) =>
            new ValidationResult(new List<string> { error });

        public static ValidationResult Invalid(IEnumerable<string> errors) =>
            new ValidationResult(errors.ToList());

        public static ValidationResultBuilder Builder() => new ValidationResultBuilder();
    }

    public sealed class ValidationResultBuilder
    {
        private readonly List<string> _errors = new List<string>();

        public ValidationResultBuilder AddErrorIf(bool condition, string error)
        {
            if (condition) _errors.Add(error);
            return this;
        }

        public ValidationResult Build() =>
            _errors.Count == 0 ? ValidationResult.Valid() : ValidationResult.Invalid(_errors);
    }
}
