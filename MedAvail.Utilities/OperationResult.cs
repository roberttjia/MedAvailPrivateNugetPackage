using System.Collections.Generic;
using System.Linq;

namespace MedAvail.Utilities
{
    public sealed class OperationResult<T>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public IReadOnlyList<string> Errors { get; }

        private OperationResult(bool isSuccess, T? value, IReadOnlyList<string> errors)
        {
            IsSuccess = isSuccess;
            Value = value;
            Errors = errors;
        }

        public static OperationResult<T> Ok(T value) =>
            new OperationResult<T>(true, value, new List<string>());

        public static OperationResult<T> Fail(string error) =>
            new OperationResult<T>(false, default, new List<string> { error });

        public static OperationResult<T> Fail(IEnumerable<string> errors) =>
            new OperationResult<T>(false, default, errors.ToList());

        public string ErrorSummary =>
            IsSuccess ? string.Empty : string.Join("; ", Errors);
    }
}
